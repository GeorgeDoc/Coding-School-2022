﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Schedule
    {
        public Guid ID { get; }
        public Guid CourseID { get; }
        public Guid ProfessorID { get; }
        public DateTime Callendar { get; set; }

        public Schedule()
        {
            ID = Guid.NewGuid();
        }
    }
}
