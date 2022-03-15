namespace Session_07_08
{
    public partial class UniversityForm : Form
    {
        public UniversityForm()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Open Methods
        private void openToolStripMenuItem_Click(object sender, EventArgs e) // Open file
        {        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)  //Open Student
        {
            Business bus = new Business();
            bus.StudentOpen();
        }

        private void openToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Business bus = new Business();

        }

        private void openToolStripMenuItem4_Click(object sender, EventArgs e) // Open Course Form
        {
            CourseForm form = new CourseForm();
            form.Show();
        }
    }
}