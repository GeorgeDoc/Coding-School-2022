using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class TransactionLineLIneController : ControllerBase{

        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;

        public TransactionLineLIneController(IEntityRepo<TransactionLine> transactionLineRepo) {
            _transactionLineRepo = transactionLineRepo;
        }

        [HttpGet("getallLines")]
        public async Task<IEnumerable<TransactionLineViewModel>> Get() { //get all

            var result = await _transactionLineRepo.GetAllAsync();
            return result.Select(x => new TransactionLineViewModel {
                Id = x.Id,
                TransactionID = x.TransactionID,
                ItemID = x.ItemID,
                Quantity = x.Quantity,
                ItemPrice = x.ItemPrice,
                NetValue = x.NetValue,
                DiscountPercent = x.DiscountPercent,
                DiscountValue = x.DiscountValue,
                TotalValue = x.TotalValue
            });
        }

        [HttpGet("one{id}")] // get one
        public async Task<TransactionLineEditViewModel> Get(Guid id) {

            TransactionLineEditViewModel model = new();
            if (id != Guid.Empty) {
                var existing = await _transactionLineRepo.GetByIdAsync(id);
                model.Id = existing.Id;
                model.TransactionID = existing.TransactionID;
                model.ItemID = existing.ItemID;
                model.Quantity = existing.Quantity;
                model.ItemPrice = existing.ItemPrice;
                model.NetValue = existing.NetValue;
                model.DiscountPercent = existing.DiscountPercent;
                model.DiscountValue = existing.DiscountValue;
                model.TotalValue = existing.TotalValue;
            }
            return model;
        }

        [HttpPost]
        public async Task Post(TransactionLineEditViewModel line) {
            var newTransactionLine = new TransactionLine() {
                Id = line.Id,
                TransactionID = line.TransactionID,
                ItemID = line.ItemID,
                Quantity = line.Quantity,
                ItemPrice = line.ItemPrice,
                NetValue = line.NetValue,
                DiscountPercent = line.DiscountPercent,
                DiscountValue = line.DiscountValue,
                TotalValue = line.TotalValue
            };
            await _transactionLineRepo.CreateAsync(newTransactionLine);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {
            await _transactionLineRepo.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionLineEditViewModel line) {
            var lineToUpdate = await _transactionLineRepo.GetByIdAsync(line.Id);
            if (lineToUpdate == null) return NotFound();

            lineToUpdate.Id = line.Id;
            lineToUpdate.TransactionID = line.TransactionID;
            lineToUpdate.ItemID = line.ItemID;
            lineToUpdate.Quantity = line.Quantity;
            lineToUpdate.ItemPrice = line.ItemPrice;
            lineToUpdate.NetValue = line.NetValue;
            lineToUpdate.DiscountPercent = line.DiscountPercent;
            lineToUpdate.DiscountValue = line.DiscountValue;
            lineToUpdate.TotalValue = line.TotalValue;

            await _transactionLineRepo.UpdateAsync(line.Id, lineToUpdate);

            return Ok();
        }
    }
}
