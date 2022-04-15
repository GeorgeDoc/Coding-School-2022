using FuelStation.EF.Repositories;
using FuelStation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Forms {
    public partial class CustomersForm : Form {

        private readonly IEntityRepo<Customer> _customerRepo;
        private List<Customer> _customers = new List<Customer>();

        public CustomersForm(IEntityRepo<Customer> customerRepo) {
            InitializeComponent();
            _customerRepo = customerRepo;
        }

        private void CustomersForm_Load(object sender, EventArgs e) {
            RefreshCustomers();
        }

        private void RefreshCustomers() { 
            _customerRepo.GetAllAsync().Wait();
            dataGridView1.DataSource = _customers;
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void btnCustCancel_Click(object sender, EventArgs e) {
            HomeForm form = new HomeForm();
            form.Show();
            this.Close();
        }
    }
}
