using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Univeristy : Institute
    {
        public Student[] Students { get; set; }
        public Course[] Courses { get; set; }
        public Grade[] Grades { get; set; }
        public Schedule[] ScheduledCourses { get; set; }

        public Student[] GetStudents() { return Students; }
        public Course[] GetCourses() { return Courses; }
        public Grade[] GetGrades() { return Grades; }
        public void SetScedule(Guid CourseID, Guid ProfessorID, DateTime datetime) { }


        public Univeristy()
        {
            Students = new Student[30];
            Courses = new Course[20];
            ScheduledCourses = new Schedule[60];
        }
    }
}
