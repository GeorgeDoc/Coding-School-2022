using FuelStation.EF.Repositories;
using FuelStation.Models;

namespace FuelStation.Forms {
    public partial class HomeForm : Form {

        //private readonly IEntityRepo<Employee> _employeeRepo;
        public HomeForm(){//IEntityRepo<Employee> employeeRepo) {
            InitializeComponent();
            //_employeeRepo = employeeRepo;
            //Program.ServiceProvider.
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
    }
}