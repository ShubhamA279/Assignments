using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee s1 = new Employee(50000);

            
            s1.GetTotalSalary();
            s1.NetSalary();

            Console.WriteLine(s1.DisplayNetSalary());


        }
    }
}
