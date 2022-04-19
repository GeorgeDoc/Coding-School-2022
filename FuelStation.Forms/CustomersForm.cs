using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Forms {
    public partial class CustomersForm : Form {

        private readonly IEntityRepo<Customer> _customerRepo;
        private List<Customer> _customers = new List<Customer>();

        public BindingSource bsCustomers { get; set; }


        public CustomersForm(IEntityRepo<Customer> customerRepo) {
            InitializeComponent();
            _customerRepo = customerRepo;
        }

        private async void CustomersForm_Load(object sender, EventArgs e) {
            var httpClient = new HttpClient();
            //httpClient.BaseAddress = new Uri("https://localhost:7294");
            httpClient.BaseAddress = new Uri("http://localhost:5294");
            var response = await httpClient.GetFromJsonAsync<List<CustomerViewModel>>("Customer");
            
            RefreshCustomers();
        }

        private async void RefreshCustomers() { 
            _customerRepo.GetAllAsync().Wait();
            gvCustomers.DataSource = _customers;
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void btnCustCancel_Click(object sender, EventArgs e) {
            HomeForm form = new HomeForm();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
