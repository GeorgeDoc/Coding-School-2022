using FuelStation.Blazor.Shared;
using System.Net.Http.Json;

namespace FuelStation.Blazor.Client.Pages {
    public partial class Employee {
        private bool isLoading = true;
        List<EmployeeViewModel> customerList = new();
        //List<EmployeeViewModel> customerList = new List<EmployeeViewModel>();
        private string CardNo { get; set; }

        protected override async Task OnInitializedAsync() {
            await LoadEmployeesFromServer();
            isLoading = false;
        }

        private async Task LoadEmployeesFromServer() { // TODO: better as a service. not good to test with server connection
            customerList = await httpClient.GetFromJsonAsync<List<EmployeeViewModel>>("Employee");
        }

        async Task AddEmployee() {
            navigationManager.NavigateTo("/customers/edit");
        }

        async Task EditEmployee(EmployeeViewModel customerToEdit) {
            navigationManager.NavigateTo($"/customers/edit{customerToEdit.Id}");
        }

        async Task DeleteEmployee(EmployeeViewModel customerToDelete) {
            //var confirm = await jsRuntime.InvokeAsync<bool>("confirmJS", null); // ΓΙΑΤΙ ΜΕ ΤΑΛΑΙΠΟΡΕΙΣ  ΒΡΑΔΙΑΤΙΚΟ
            if (true) {// (confirm) {
                var response = await httpClient.DeleteAsync($"customer/{customerToDelete.Id}");
                response.EnsureSuccessStatusCode();
                await LoadEmployeesFromServer();
            }
        }
    }
}
