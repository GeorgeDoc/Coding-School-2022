using Classes;
using Session_15_EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15_EF.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {
        public async Task Create(Transaction entity) {

            using var context = new Session_15_Context();
            context.Transactions.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            
            using var context = new Session_15_Context();
            var foundTransaction = context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction is null)
                return;

            context.Transactions.Remove(foundTransaction);
            await context.SaveChangesAsync();
        }

        public List<Transaction> GetAll() {
            using var context = new Session_15_Context();
            return context.Transactions.ToList();
        }

        public Transaction? GetById(Guid id) {
            using var context = new Session_15_Context();
            return context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, Transaction entity) {
            using var context = new Session_15_Context();
            var foundTransaction = context.Transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTransaction is null)
                return;
            else {
                foundTransaction.TotalPrice = entity.TotalPrice;
                foundTransaction.TransCost = entity.TransCost;
            }
            await context.SaveChangesAsync();
        }
    }
}
