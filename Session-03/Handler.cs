using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Handler
    {
        private const string FILE_NAME = "Storage.json";
        private const string STUDENT_FILE = "StudentStorage.json";
        private const string PROFESSOR_FILE = "ProfessorStorage.json";

        private Student _student;
        private Professor _professor;
        private Course _course;


        public void SaveStudent()
        {
            try
            {
                string json = JsonSerializer.Serialize(_student);
                File.WriteAllText(STUDENT_FILE, json);
                //write a log msg 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void SaveProfessor()
        {
            try
            {
                string json = JsonSerializer.Serialize(_professor);
                File.WriteAllText(PROFESSOR_FILE, json);
                //write a log msg 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void SaveCourse() {
            try
            {
                string json = JsonSerializer.Serialize(_course);
                File.WriteAllText(FILE_NAME, json);
                //write a log msg 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public Handler() { }
    }
}
