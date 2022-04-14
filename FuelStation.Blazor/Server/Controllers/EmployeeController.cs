using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers {

    [ApiController]
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

        [HttpGet("{id}")] // get one
        public async Task<EmployeeEditViewModel> Get(Guid id) {

            var result = await _employeeRepo.GetByIdAsync(id);
            return new EmployeeEditViewModel {
                Id = result.Id,
                Name = result.Name,
                Surname = result.Surname,
                EmployeeType = result.EmployeeType,
                SallaryPerMonth = result.SallaryPerMonth,
                HireDateStart = result.HireDateStart,
                HireDateEnd = result.HireDateEnd
            };
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
