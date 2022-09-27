using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day15
{
    public class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        // public Student[] Students { get; set; }
        public ArrayList Students { get; set; }

    }

    public class Student
    {

        public string StudName { get; set; }
        public string City { get; set; }

    }
}
