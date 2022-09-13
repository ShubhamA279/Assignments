using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day06
{
    public class Employee
    {

        int empid;
        string name;
        string company;
        int age;
        float salary;

        public void AcceptValue()
        {
            empid = 123;
            name = "Shubham";
            company = "ThinkQuotient";
            age = 24;
            salary = 50000.00f;

        }

        public void PrintValue()
        {
            Console.WriteLine("empid is : " + empid);
            Console.WriteLine("name is : " + name);
            Console.WriteLine("company is : " + company);
            Console.WriteLine("age is : " + age);
            Console.WriteLine("salary is : " + salary);

        }
    }
}
