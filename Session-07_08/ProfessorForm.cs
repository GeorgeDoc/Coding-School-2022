using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Session_03;

namespace Session_07_08
{
    public partial class ProfessorForm : Form
    {
        public ProfessorForm()
        {
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        private void Professor_Load(object sender, EventArgs e)
        {
            //Handler._student
        }

        public void ClearDataProf() // empty entries
        {
            LbCourses.Text = string.Empty;
            TeName.Text = string.Empty;
            TeRank.Text = string.Empty; 
            TeAge.Text = string.Empty;  
        }

        public void ClearData() // reload form
        {
            ProfessorForm prof = new ProfessorForm();
            prof.Show();
            this.Close();
        }
    }
}
