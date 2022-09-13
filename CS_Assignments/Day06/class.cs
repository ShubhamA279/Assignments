using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day06
{
    internal class Class
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptValue();
            student.DisplayValue();
            string data = student.DisplayValue();
            Console.WriteLine(data);

            Console.WriteLine();
            Console.WriteLine();

            Employee Emp = new Employee();
            Emp.AcceptValue();
            Emp.PrintValue();


        }
    }
}
