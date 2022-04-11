using FuelStation.EF.Context;
using FuelStation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {

        private readonly FuelStationContext _context;

        public TransactionLineRepo(FuelStationContext dbContext) { 
            _context = dbContext;
        }

        public async Task CreateAsync(TransactionLine entity) {
            await _context.TransactionLines.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id) { 
            var foundTransactionLine = await _context.TransactionLines.SingleOrDefaultAsync(tl => tl.Id == id);
            if (foundTransactionLine is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            _context.TransactionLines.Remove(foundTransactionLine);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TransactionLine>> GetAllAsync() {
            //return await _context.TransactionLines.ToListAsync();
            return await _context.TransactionLines.Include(tl => tl.Item).ToListAsync();
        }

        public async Task<TransactionLine?> GetByIdAsync(Guid id) {
            return await _context.TransactionLines.SingleOrDefaultAsync(tl => tl.Id == id);
            //return await _context.TransactionLines.AsNoTracking().SingleOrDefaultAsync(tl => tl.Id == id);
        }

        public async Task UpdateAsync(Guid id, TransactionLine entity) {
            var foundTransactionLine = await _context.TransactionLines.SingleOrDefaultAsync(tl => tl.Id == id);
            if (foundTransactionLine is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            foundTransactionLine.DiscountPercent = entity.DiscountPercent;
            foundTransactionLine.ItemID = entity.ItemID;
            foundTransactionLine.TransactionID = entity.TransactionID;
            //foundTransactionLine.NetValue = entity.NetValue;
            //foundTransactionLine.TotalValue = entity.TotalValue;
            //foundTransactionLine.DiscountValue = entity.DiscountValue;
            await _context.SaveChangesAsync();
        }
    }
}
