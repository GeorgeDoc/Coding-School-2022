using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {   // TODO: make seperatte lists for current and old employees based on HireDateEnd.
                                                    //       By default, show current. With a select, show old.
    [ApiController]                                 //       DELETE should put DateTime.Now as HireDateEnd (but can still be editable)
    [Route("[controller]")]
    public class EmployeeController : ControllerBase {

        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }

        [HttpGet("getallemployees")]
        public async Task<IEnumerable<EmployeeViewModel>> Get() { //get all

            var result = await _employeeRepo.GetAllAsync();
            return result.Select(x => new EmployeeViewModel {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                EmployeeType = x.EmployeeType,
                SallaryPerMonth = x.SallaryPerMonth,
                HireDateStart = x.HireDateStart,
                HireDateEnd = x.HireDateEnd
            });
        }

        [HttpGet("one{id}")] // get one
        public async Task<EmployeeEditViewModel> Get(Guid id) {

            EmployeeEditViewModel model = new();
            if (id != Guid.Empty) {   //If exists, fill with details to Edit
                var existing = await _employeeRepo.GetByIdAsync(id);
                model.Id = existing.Id;
                model.Name = existing.Name;
                model.Surname = existing.Surname;
                model.EmployeeType = existing.EmployeeType;
                model.SallaryPerMonth = existing.SallaryPerMonth;
                model.HireDateStart = existing.HireDateStart;
                model.HireDateEnd = existing.HireDateEnd;
            }

            //var result = await _employeeRepo.GetByIdAsync(id);
            //return new EmployeeEditViewModel {
            //Id = result.Id,
            //Name = result.Name,
            //Surname = result.Surname,
            //EmployeeType = result.EmployeeType,
            //SallaryPerMonth = result.SallaryPerMonth,
            //HireDateStart = result.HireDateStart,
            //HireDateEnd = result.HireDateEnd
            //};
            return model;
        }

        [HttpPost]
        public async Task Post(EmployeeEditViewModel employee) {
            var newEmployee = new Employee() {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                EmployeeType = employee.EmployeeType,
                SallaryPerMonth = employee.SallaryPerMonth,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd
            };
            await _employeeRepo.CreateAsync(newEmployee);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id) {
            await _employeeRepo.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(EmployeeEditViewModel employee) { 
            var employeeToUpdate = await _employeeRepo.GetByIdAsync(employee.Id);
            if (employeeToUpdate == null) return NotFound();

            if(employee.HireDateEnd==null && employeeToUpdate.HireDateEnd!=null) {

            }

            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.Surname = employee.Surname;
            employeeToUpdate.EmployeeType = employee.EmployeeType;
            employeeToUpdate.SallaryPerMonth = employee.SallaryPerMonth;
            employeeToUpdate.HireDateStart = employee.HireDateStart;    
            employeeToUpdate.HireDateEnd = employee.HireDateEnd;

            await _employeeRepo.UpdateAsync(employee.Id, employeeToUpdate);

            return Ok();
        }
    }            // TODO: HireEndDate like todo.Finished?
                
}
