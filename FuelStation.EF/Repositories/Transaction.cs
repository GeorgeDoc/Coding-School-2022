using FuelStation.EF.Context;
using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {

        private readonly FuelStationContext _context;
        public TransactionRepo(FuelStationContext dbContext) { 
            _context = dbContext;
        }

        public async Task CreateAsync(Transaction entity) {
            await _context.Transactions.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id) {
            var foundTransaction = await _context.Transactions.SingleOrDefaultAsync(transaction => transaction.Id == id);
            if (foundTransaction is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            _context.Transactions.Remove(foundTransaction);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Transaction>> GetAllAsync() {
            return await _context.Transactions.
                Include(t => t.Customer).
                Include(t => t.Employee).
                Include(t => t.TransactionLines).ToListAsync();
        }

        public async Task<Transaction?> GetByIdAsync(Guid id) {
            return await _context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefaultAsync();
            //return await _context.Transactions.
            //Include(t => t.Customer).
            //Include(t => t.Employee).
            //Include(t => t.TransactionLines).
            //Where(transaction => transaction.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(Guid id, Transaction entity) {
            var foundTransaction = await _context.Transactions.SingleOrDefaultAsync(transaction => transaction.Id == id);
            if (foundTransaction is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            foundTransaction.Date = entity.Date;
            foundTransaction.CustomerID = entity.CustomerID;
            foundTransaction.EmployeeID = entity.EmployeeID;
            foundTransaction.TransactionLines = entity.TransactionLines;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            await _context.SaveChangesAsync();
        }
    }
}
