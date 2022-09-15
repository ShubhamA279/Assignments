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
            Employee e1 = new Employee("vivek", 50000, 200);       
            e1.GetTotalSalary();
            e1.NetSalary();
            Console.WriteLine(e1.DisplaySalaryDetails());


            Console.WriteLine();

            Employee e2 = new Employee("test", 30000, 200); 
            e2.GetTotalSalary();
            e2.NetSalary();
            Console.WriteLine(e2.DisplaySalaryDetails());

            Console.WriteLine(Employee.DisplayCount());


        }
    }
}
