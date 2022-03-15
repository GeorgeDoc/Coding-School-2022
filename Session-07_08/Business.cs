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
        public static Business bussinessFormInstance; //create an instance to have access to this form

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
        public List<Course> Courses { get; set; }



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


        CourseForm courseForm = CourseForm.courseFormInstance;
        public void CourseOpen()
        {
            CourseForm courseForm = new CourseForm(); //
            courseForm.Show();
        }

        public Course CourseCreate()
        {
            Univeristy univeristy = new Univeristy();
            univeristy.Courses = Courses;
            Course course = univeristy.CourseAdd();
            return course;
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
                //_selectedCourse = courseForm.Courses[courseForm.lbCourses.SelectedIndex];
            }
        }
        public void ShowCourseList()
        {
            CourseForm.courseFormInstance.lbCourses.Items.Clear();

            Univeristy univeristy = new Univeristy();
            foreach (Course item in univeristy.Courses)
            {
                if (item != null)
                {
                    courseForm.lbCourses.Items.Add(string.Format("{0}", item.Subject));
                }
            }
        }


        private Professor CreateProffesor()
        {
            return _professor; 
        }

        public Business()        {
            InitializeComponent();
            bussinessFormInstance = this; // instance to have access from other forms
        }

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
