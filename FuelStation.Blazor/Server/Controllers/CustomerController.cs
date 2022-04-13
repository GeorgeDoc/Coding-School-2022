using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase {   // TODO: make deleted customers page like recording

        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo) {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerViewModel>> Get() { //get all, change it to GetAll() maybe?
            //try {
            //    var result = await _customerRepo.GetAllAsync();
            //    return result.Select(x => new CustomerViewModel {
            //        Id = x.Id,
            //        Name = x.Name,
            //        Surname = x.Surname,
            //        CardNumber = x.CardNumber,
            //    });
            //}
            //catch (Exception) {
            //    return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieveng data from server");               
            //}

            var result = await _customerRepo.GetAllAsync();
            return result.Select(x => new CustomerViewModel {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                CardNumber = x.CardNumber,
            });
        }

        [HttpGet("{id}")] // get one
        public async Task<CustomerEditViewModel> Get(Guid id) { //get all

            var result = await _customerRepo.GetByIdAsync(id);
            return new CustomerEditViewModel {
                Id = result.Id,
                Name = result.Name,
                Surname = result.Surname,
                CardNumber = result.CardNumber,
            };
        }

        [HttpPost]
        public async Task Post(CustomerEditViewModel customer) {
            var newCustomer = new Customer() {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber
            };
        await _customerRepo.CreateAsync(newCustomer);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) { 
            await _customerRepo.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CustomerEditViewModel customer) { // ActionResult for NotFound return
            var customerToUpdate = await _customerRepo.GetByIdAsync(customer.Id);
            if (customerToUpdate == null) return NotFound(); 

            customerToUpdate.Name = customer.Name;
            customerToUpdate.Surname = customer.Surname;
            customerToUpdate.CardNumber = customer.CardNumber;

            await _customerRepo.UpdateAsync(customer.Id, customerToUpdate);

            return Ok();
        }
    }
}
