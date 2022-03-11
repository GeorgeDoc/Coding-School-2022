using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Session_03;

namespace Session_07_08
{
    internal class Business : Form
    {
        private const string FILE_NAME = "Storage.json";
        private const string STUDENT_FILE = "StudentStorage.json";
        private const string PROFESSOR_FILE = "ProfessorStorage.json";

        //private Session_03.Student _student;
        //private Professor _professor;
        //private Course _course;

        public void ClearData()
        {
            Form form = new Form();
            form.Show();
            this.Close();
        }

        public void StudentOpen()
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
        }
        public void ProfessorOpen()
        {
            ProfessorForm professorForm = new ProfessorForm();
            professorForm.Show();
        }
        public void CourseOpen()
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
        }

        
        public void StudentLoad()
        {

        }


        public Business()        {        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Business
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Business";
            this.Load += new System.EventHandler(this.Business_Load);
            this.ResumeLayout(false);

        }

        private void Business_Load(object sender, EventArgs e)
        {        }
    }
}
