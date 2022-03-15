using Session_03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07_08
{
    public partial class CourseForm : Form
    {
        public static CourseForm courseFormInstance; //create an instance to have access to this form
        public ListBox lbCourses;
        public List<Course> Courses { get; set; }
        Course course = new Course("testCode", "testSubject");

        public Course _selectedCourse;
        public CourseForm()
        {
            InitializeComponent();
            courseFormInstance = this; // instance to have access from other forms
            lbCourses = listBoxCourse;
        }

        private void BtnNew_Click(object sender, EventArgs e) // New Course
        {
            Course course = new Course("testCode", "testSubject");
            //Course course = Business.bussinessFormInstance.CourseCreate();
            Business.bussinessFormInstance.ShowCourseList();
            Courses.Add(course);
            listBoxCourse.SelectedIndex = Courses.IndexOf(course);
        }

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseSelect();

            //DisplayCourse();
        }

        public void CourseSelect()
        {
            if (_selectedCourse != null)
            {
                _selectedCourse = Courses[listBoxCourse.SelectedIndex];
            }
        }

        private void BtnSave_Click(object sender, EventArgs e) // save Course
        {
            // update Course
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            Business business = new Business(); // otherwise null obj reference
            Business.bussinessFormInstance.ShowCourseList();

        }
    }
}
