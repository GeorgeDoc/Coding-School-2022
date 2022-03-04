using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person
    {
        public string Rank { get; set; }
        public void SetRank(string rank)
        {
            while (rank != null)
            {
                if (rank.ToLower().Equals("full") | rank.ToLower().Equals("associate") | rank.ToLower().Equals("assistant professor"))
                {
                    Rank = rank;
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
            }
        }

        public Course[] Courses { get; set; }



        public void Teach(Course course, DateTime datetime)
        {

        }



        public void SetGrade(Guid studentID, Guid courseID, int grade)
        { //  

        }

        public string GetName()
        {
            return "Dr. " + _name;
        }

        public Professor()
        {

        }
    }
}
