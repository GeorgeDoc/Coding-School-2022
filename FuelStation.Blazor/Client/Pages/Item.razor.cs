using FuelStation.Blazor.Shared;
using System.Net.Http.Json;

namespace FuelStation.Blazor.Client.Pages {
    public partial class Item {
        private bool isLoading = true;
        List<ItemViewModel> itemList = new();
        //List<ItemViewModel> itemList = new List<ItemViewModel>();

        protected override async Task OnInitializedAsync() {
            await LoadItemsFromServer();
            isLoading = false;
        }

        private async Task LoadItemsFromServer() { 
            itemList = await httpClient.GetFromJsonAsync<List<ItemViewModel>>("Item/getallitems");
        }

        async Task AddItem() {
            navigationManager.NavigateTo("/items/edit");
        }

        async Task EditItem(ItemViewModel itemToEdit) {
            navigationManager.NavigateTo($"/items/edit{itemToEdit.Id}");
        }

        async Task DeleteItem(ItemViewModel itemToDelete) {
            //var confirm = await jsRuntime.InvokeAsync<bool>("confirmJS", null); 
            if (true) {// (confirm) {
                var response = await httpClient.DeleteAsync($"item/{itemToDelete.Id}");
                response.EnsureSuccessStatusCode();
                await LoadItemsFromServer();
            }
        }
    }
}
