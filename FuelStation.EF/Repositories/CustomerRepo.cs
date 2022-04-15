using FuelStation.EF.Context;
using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {

        private readonly FuelStationContext _context;
        public CustomerRepo(FuelStationContext dbContext) { 
            _context = dbContext;
        }

        public async Task CreateAsync(Customer entity) {
            await _context.Customers.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id) { // TODO: Can make a function for lines 24-26? repeated across all repos
            var foundCustomer = await _context.Customers.SingleOrDefaultAsync(customer => customer.Id.Equals(id)); 
            if (foundCustomer == null) 
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            _context.Customers.Remove(foundCustomer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAllAsync() {
            return await _context.Customers.ToListAsync();
            //return await _context.Customers.AsNoTracking().ToListAsync(); // improve performance if only read
        }

        public async Task<Customer?> GetByIdAsync(Guid id) { 
            return await _context.Customers.SingleOrDefaultAsync(customer => customer.Id.Equals(id));
            //return await _context.Customers.Where(customer => customer.Id == id).SingleOrDefaultAsync(); // where has worse performance
        }
        public async Task GetByCodeAsync(string code) { // FIND BY CARD CODE HERE?
            var foundCustomer = await _context.Customers.SingleOrDefaultAsync(customer => customer.CardNumber.Equals(code));
        }

        public async Task UpdateAsync(Guid id, Customer entity) {
            var foundCustomer = await _context.Customers.SingleOrDefaultAsync(customer => customer.Id.Equals(id));
            if(foundCustomer == null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            foundCustomer.Name = entity.Name;
            foundCustomer.Surname = entity.Surname;
            //foundCustomer.CardNumber = entity.CardNumber; //should this be changable?
        }
    }
}
