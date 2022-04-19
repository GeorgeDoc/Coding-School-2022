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
    public partial class LogInForm : Form {

        private HomeForm Home;
        public string _username { get; set; }
        public string _password { get; set; }

        public LogInForm() {
            InitializeComponent();
        }

        private void lblClear_Click(object sender, EventArgs e) {
            tbUsername.Text = String.Empty;
            tbPass.Text = String.Empty;
        }

        private void lblExit_Click(object sender, EventArgs e) {
            //set user to null
            System.Environment.Exit(1);
            //System.Windows.Forms.Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            //_password = tbPass.Text;
            //_username = tbUsername.Text;
            //User user = new User(_username, _password);
            // If authenticate true
            Home = new HomeForm();
            Home.Show();
            this.Hide();
        }
    }
}
