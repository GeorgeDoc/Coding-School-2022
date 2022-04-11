using FuelStation.EF.Context;
using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class ItemRepo : IEntityRepo<Item> {

        private readonly FuelStationContext _context;

        public ItemRepo(FuelStationContext dbContext) {
            _context = dbContext;
        }

        public async Task CreateAsync(Item entity) {
            await _context.Items.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id) {
            var foundItem = await _context.Items.SingleOrDefaultAsync(item => item.Id == id);
            if (foundItem == null) 
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            await _context.SaveChangesAsync();
        }

        public async Task<List<Item>> GetAllAsync() {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item?> GetByIdAsync(Guid id) {
            return await _context.Items.Where(item => item.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(Guid id, Item entity) {
            var foundItem = await _context.Items.SingleOrDefaultAsync(item => item.Id == id);
            if (foundItem == null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            foundItem.Description = entity.Description;
            foundItem.Code = entity.Code;
            foundItem.Price = entity.Price;
            foundItem.Cost = entity.Cost;
            foundItem.ItemType = entity.ItemType;
            await _context.SaveChangesAsync();
        }
    }
}
