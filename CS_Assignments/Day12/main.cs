using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day12
{
    internal class Start
    {
        static void Main(string[] args)
        {
            Course[] courses =
        {
                new Course{Id=1, Name="Clanguage",Fees=10000},
                new Course{Id=2, Name="C++",Fees=11000},
                new Course{Id=3, Name="java",Fees=15000},
                new Course{Id=4, Name="c#",Fees=15000},
                new Course{Id=5, Name="Testing",Fees=18000},
            };

            foreach (Course c in courses)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("------------------------------------");
            Department[] departments =
            {
                new Department{Id=1, Name="Electrical",Location="1st floor"},
                new Department{Id=2, Name="Mechanical",Location="2ndFloor"},
                new Department{Id=3, Name="Electronics",Location="3rd floor"},
                new Department{Id=4, Name="Chemical",Location="fouth floor"},
                new Department{Id=5, Name="Instrumentation",Location="2nd floor"},
            };

            foreach (Department d in departments)
            {
                Console.WriteLine(d);
            }
        }

    }
}
