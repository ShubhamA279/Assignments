using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day08
{
    public class Student
    {
        public int Roll_No { get; set; }

        public string Name { get; set; }

        public double Percent { get; set; }

        public override string ToString()
        {
            return $"Roll No : {Roll_No} Name :{Name} Percent:{Percent}";
        }

    }
}
