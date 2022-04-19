using FuelStation.EF.Repositories;
using FuelStation.Models;

namespace FuelStation.Forms {
    public partial class HomeForm : Form {

        private readonly IEntityRepo<Customer> _customerRepo;

        public HomeForm() {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void btnMainExit_Click(object sender, EventArgs e) {
            //set user to null
            System.Environment.Exit(1);
        }

        private void btnMainBack_Click(object sender, EventArgs e) {
            LogInForm form = new LogInForm();
            form.Show();
            //set user to null
            this.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e) {
            CustomersForm form = new CustomersForm(_customerRepo);
            form.Show();
            this.Close();
        }
    }
}