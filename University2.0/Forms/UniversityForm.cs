using University2._0.Forms;

namespace University2._0
{
    public partial class UniversityForm : Form
    {
        public UniversityForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }
    }
}