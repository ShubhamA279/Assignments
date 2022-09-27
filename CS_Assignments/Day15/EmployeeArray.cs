using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day15
{
    public class Department
    {

        public int Id { get; set; }
        public string Name { get; set; }

         public Employee[] Employees { get; set; }
       // public ArrayList Employee { get; set; }


    }
    public class Employee
    {

        public int Empid { get; set; }
        public string Name { get; set; }

    }
}
