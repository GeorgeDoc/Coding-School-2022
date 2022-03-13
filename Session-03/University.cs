﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Univeristy : Institute
    {
        //public Student[] Students { get; set; }
        //public Course[] Courses { get; set; }
        //public Grade[] Grades { get; set; }
        //public Schedule[] ScheduledCourses { get; set; }

        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourses { get; set; }
        public List<Professor> Professors { get; set; }


        public List<Student> GetStudents() { return Students; }
        public List<Course> GetCourses() { return Courses; }
        public List<Grade> GetGrades() { return Grades; }
        public void SetScedule(Guid CourseID, Guid ProfessorID, DateTime datetime) { }


        public Univeristy()
        {
            Students = new List<Student>(new Student[30]); //maybe?
            Courses = new List<Course>(new Course[20]);
            ScheduledCourses = new List<Schedule>(new Schedule[60]);
        }
    }
}
