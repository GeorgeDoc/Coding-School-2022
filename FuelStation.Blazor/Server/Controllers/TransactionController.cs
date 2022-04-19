using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase {

        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo) {
            _transactionRepo = transactionRepo;
        }

        [HttpGet("getallttransactions")]
        public async Task<IEnumerable<TransactionViewModel>> Get() { //get all

            var result = await _transactionRepo.GetAllAsync();
            return result.Select(x => new TransactionViewModel {
                Id = x.Id,
                Date = x.Date,
                EmployeeID = x.EmployeeID,
                CustomerID = x.CustomerID,
                PaymentMethod = x.PaymentMethod,
                TotalValue = x.TotalValue,
            });
        }

        [HttpGet("one{id}")] // get one
        public async Task<TransactionEditViewModel> Get(Guid id) {

            TransactionEditViewModel model = new();
            if (id != Guid.Empty) {
                var existing = await _transactionRepo.GetByIdAsync(id);
                model.Id = existing.Id;
                model.Date = existing.Date;
                model.EmployeeID = existing.EmployeeID;
                model.CustomerID = existing.CustomerID;
                model.PaymentMethod = existing.PaymentMethod;
                model.TotalValue = existing.TotalValue;
            }
            return model;
        }

        [HttpPost]
        public async Task Post(TransactionEditViewModel transaction) {
            var newTransaction = new Transaction() {
                Id = transaction.Id,
                Date = transaction.Date,
                EmployeeID = transaction.EmployeeID,
                CustomerID = transaction.CustomerID,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = transaction.TotalValue,
            };
            await _transactionRepo.CreateAsync(newTransaction);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {
            await _transactionRepo.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionEditViewModel transaction) {
            var transactionToUpdate = await _transactionRepo.GetByIdAsync(transaction.Id);
            if (transactionToUpdate == null) return NotFound();

            transactionToUpdate.Id = transaction.Id;
            transactionToUpdate.Date = transaction.Date;
            transactionToUpdate.EmployeeID = transaction.EmployeeID;
            transactionToUpdate.CustomerID = transaction.CustomerID;
            transactionToUpdate.PaymentMethod = transaction.PaymentMethod;
            transactionToUpdate.TotalValue = transaction.TotalValue;

            await _transactionRepo.UpdateAsync(transaction.Id, transactionToUpdate);

            return Ok();
        }
    }
}
