using FuelStation.Blazor.Shared;
using System.Net.Http.Json;

namespace FuelStation.Blazor.Client.Pages {
    public partial class Customers {

        private bool isLoading = true;
        List<CustomerViewModel> customerList = new();
        //List<CustomerViewModel> customerList = new List<CustomerViewModel>();
        private string CardNo { get; set; }  //TODO: need  this?

        protected override async Task OnInitializedAsync() {
            await LoadCustomersFromServer();
            isLoading = false;
        }

        private async Task LoadCustomersFromServer() { // TODO: better as a service. not good to test with server connection
            customerList = await httpClient.GetFromJsonAsync<List<CustomerViewModel>>("Customer");
        }

        async Task AddCustomer() {
            navigationManager.NavigateTo("/customers/edit");
        }

        async Task EditCustomer(CustomerViewModel customerToEdit) {
            navigationManager.NavigateTo($"/customers/edit{customerToEdit.Id}");
        }

        async Task DeleteCustomer(CustomerViewModel customerToDelete) {
            //var confirm = await jsRuntime.InvokeAsync<bool>("confirmJS", null); // ΓΙΑΤΙ ΜΕ ΤΑΛΑΙΠΟΡΕΙΣ  ΒΡΑΔΙΑΤΙΚΟ
            if (true) {// (confirm) {
                var response = await httpClient.DeleteAsync($"customer/{customerToDelete.Id}");
                response.EnsureSuccessStatusCode();
                await LoadCustomersFromServer();
            }
        }
    }
}
