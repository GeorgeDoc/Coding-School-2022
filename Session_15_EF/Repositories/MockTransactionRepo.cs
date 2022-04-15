using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_15_EF.Repositories {
    internal class MockTransactionRepo {

        private List<Transaction> _transactions = new List<Transaction>() {
            new Transaction() { TotalPrice = 10, TransCost = 7},
            new Transaction() { TotalPrice = 8, TransCost = 4}
        };

        public Task Create(Transaction entity) {
            _transactions.Add(entity);
            return Task.CompletedTask;
        }

        public Task Delete(Guid id) {
            var foundTrans = _transactions.SingleOrDefault(transaction => transaction.ID == id);
            if (foundTrans is null)
                return Task.CompletedTask;
            _transactions.Remove(foundTrans);
            return Task.CompletedTask;
        }

        public List<Transaction> GetAll() {

            return _transactions;
        }

        public Transaction? GetById(Guid id) {
            return _transactions.SingleOrDefault(transaction => transaction.ID == id);
        }

        public Task Update(Guid id, Transaction entity) {
            var foundTrans = _transactions.SingleOrDefault(_transaction => _transaction.ID == id);
            if (foundTrans is null)
                return Task.CompletedTask;
            else {
                foundTrans.TotalPrice = entity.TotalPrice;
                foundTrans.TransCost = entity.TransCost;
                //other properties should probalby be read only
            }
            return Task.CompletedTask;
        }
    }
}
