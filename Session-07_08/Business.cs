using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Session_03;

namespace Session_07_08
{
    internal class Business : Form
    {
        private const string FILE_NAME = "Storage.json";

        private const string STUDENT_FILE = "StudentStorage.json";
        private Session_03.Student _student;
        private Session_03.Student _selectedStudent;

        private const string PROFESSOR_FILE = "ProfessorStorage.json";
        private Professor _professor;
        private Professor _selectedProfessor;

        private const string COURSE_FILE = "CourseStorage.json";
        private Course _course;
        public Course _selectedCourse;


        public void ClearData() // well, sort of
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


        CourseForm courseForm = new CourseForm();
        public void CourseOpen()
        {
            CourseForm courseForm = new CourseForm(); //
            courseForm.Show();
        }

        public void CourseSave()
        {
            string json = JsonSerializer.Serialize(_course);
            File.WriteAllText(COURSE_FILE, json);
            //log the change
        }

        public void LoadCourseList()
        {
            string s = File.ReadAllText(COURSE_FILE);
            _course = (Course)JsonSerializer.Deserialize(s, typeof(Course));
        }

        public void CourseSelect()
        {
            if (_selectedCourse != null)
            {
                _selectedCourse = CourseForm.courseFormInstance.Courses[CourseForm.courseFormInstance.lbCourses.SelectedIndex];
            }
        }


        private Professor CreateProffesor()
        {
            return _professor; 
        }


        public void ShowCourseList()
        {
            listBox.I
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
