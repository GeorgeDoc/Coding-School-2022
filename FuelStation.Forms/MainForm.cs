using FuelStation.EF.Repositories;
using FuelStation.Models;

namespace FuelStation.Forms {
    public partial class MainForm : Form {

        private readonly IEntityRepo<Employee> _employeeRepo;
        public MainForm(IEntityRepo<Employee> employeeRepo) {
            InitializeComponent();
            _employeeRepo = employeeRepo;
            //Program.ServiceProvider.
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }
    }
}