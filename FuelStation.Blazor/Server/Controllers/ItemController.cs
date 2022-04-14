using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase {

        private readonly IEntityRepo<Item> _itemRepo;

        public ItemController(IEntityRepo<Item> itemRepo) {
            _itemRepo = itemRepo;
        }

        [HttpGet("getallitems")]
        public async Task<IEnumerable<ItemViewModel>> Get() { //get all

            var result = await _itemRepo.GetAllAsync();
            return result.Select(x => new ItemViewModel {
                Id = x.Id,
                Code = x.Code,
                Description = x.Description,
                ItemType = x.ItemType,
                Price = x.Price,
                Cost = x.Cost,
            });
        }

        [HttpGet("{id}")] // get one
        public async Task<ItemEditViewModel> Get(Guid id) {

            var result = await _itemRepo.GetByIdAsync(id);
            return new ItemEditViewModel {
                Id = result.Id,
                Code = result.Code,
                Description = result.Description,
                ItemType = result.ItemType,
                Price = result.Price,
                Cost = result.Cost,
            };
        }

        [HttpPost]
        public async Task Post(ItemEditViewModel item) {
            var newItem = new Item() {
                Id = item.Id,
                Code = item.Code,
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost,
            };
            await _itemRepo.CreateAsync(newItem);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {
            await _itemRepo.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemEditViewModel item) {
            var itemToUpdate = await _itemRepo.GetByIdAsync(item.Id);
            if (itemToUpdate == null) return NotFound();


            itemToUpdate.Code = item.Code;
            itemToUpdate.Description = item.Description;
            itemToUpdate.ItemType = item.ItemType;
            itemToUpdate.Price = item.Price;
            itemToUpdate.Cost = item.Price;

            await _itemRepo.UpdateAsync(item.Id, itemToUpdate);

            return Ok();
        }
    }
}
