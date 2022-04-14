using FuelStation.Blazor.Shared;
using System.Net.Http.Json;

namespace FuelStation.Blazor.Client.Pages {
    public partial class Employee {
        private bool isLoading = true;
        List<EmployeeViewModel> employeeList = new();
        //List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();
        private string CardNo { get; set; }

        protected override async Task OnInitializedAsync() {
            await LoadEmployeesFromServer();
            isLoading = false;
        }

        private async Task LoadEmployeesFromServer() { 
            employeeList = await httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("Employee/getallemployees"); //needed custom uri to go to controller
        }

        async Task AddEmployee() {
            navigationManager.NavigateTo("/employees/edit");
        }

        async Task EditEmployee(EmployeeViewModel employeeToEdit) {
            navigationManager.NavigateTo($"/employees/edit{employeeToEdit.Id}");
        }

        async Task DeleteEmployee(EmployeeViewModel employeeToDelete) {
            //var confirm = await jsRuntime.InvokeAsync<bool>("confirmJS", null); // ΓΙΑΤΙ ΜΕ ΤΑΛΑΙΠΟΡΕΙΣ  ΒΡΑΔΙΑΤΙΚΟ
            if (true) {// (confirm) {
                var response = await httpClient.DeleteAsync($"employee/{employeeToDelete.Id}");
                response.EnsureSuccessStatusCode();
                await LoadEmployeesFromServer();
            }
        }
    }
}
