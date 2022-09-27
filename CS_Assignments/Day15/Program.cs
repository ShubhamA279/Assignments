using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day15
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList Employee1 = new ArrayList();
            Employee1.Add(new Employee { StudName = "Rahul", City = "Mumbai" });
            Employee1.Add(new Employee { StudName = "Amit", City = "Pune" });

            ArrayList Employee2 = new ArrayList();
            Employee2.Add(new Employee { StudName = "Yash", City = "Chiplun" });
            Employee2.Add(new Employee { StudName = "Darshan", City = "Nagpur" });


            ArrayList Employee3 = new ArrayList();
            Employee3.Add(new Employee { StudName = "Ankit", City = "London" });
            Employee3.Add(new Employee { StudName = "Manish", City = "France" });


            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Course { Id = 1, Name = "C#", Fees = 10000, Employees = Employee1 });
            arrayList.Add(new Course { Id = 2, Name = "Java", Fees = 12000, Employees = Employee2 });
            arrayList.Add(new Course { Id = 3, Name = "MVC", Fees = 15000, Employees = Employee3 });



            foreach (Course c in arrayList)
            {
                Console.WriteLine($"{c.Id} {c.Name}  {c.Fees}");
                foreach (Employee s in c.Employees)
                {
                    Console.WriteLine($"\t {s.StudName} -> {s.City}");
                }

            }
            */

            /*
            ArrayList employee1 = new ArrayList();
            employee1.Add(new Employee { Empid = 1, Name = "Amit" });
            employee1.Add(new Employee { Empid = 5, Name = "Shubham" });

            ArrayList employee2 = new ArrayList();
            employee2.Add(new Employee { Empid = 7 , Name = "Ankit" });
            employee2.Add(new Employee { Empid = 14, Name = "Manish" });


            ArrayList employee3 = new ArrayList();
            employee3.Add(new Employee { Empid = 21, Name = "Rahul" });
            employee3.Add(new Employee { Empid = 30, Name = "Satej" });


            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Department { Id = 1, Name = "Finance",  Employee = employee1 });
            arrayList.Add(new Department { Id = 2, Name = "Marketing",  Employee = employee2 });
            arrayList.Add(new Department { Id = 3, Name = "Human Resource",  Employee = employee3 });



            foreach (Department d in arrayList)
            {
                Console.WriteLine($"{d.Id} {d.Name} ");
                foreach (Employee e in d.Employee)
                {
                    Console.WriteLine($"\t {e.Empid} -> {e.Name}");
                }

            }
            */



            Employee[] emp1 = new Employee[]
             {
                new Employee { Empid = 1, Name = "Amit" },
               new Employee { Empid = 5, Name = "Shubham" }
             };

            Employee[] emp2 = new Employee[]
            {
                 new Employee { Empid = 21, Name = "Rahul" },
                new Employee { Empid = 14, Name = "Manish" },
                
            };
            Employee[] emp3 = new Employee[]
           {
                 new Employee { Empid = 21, Name = "Rahul" },
                new Employee { Empid = 30, Name = "Satej" },
                new Employee { Empid = 41, Name = "Amol" }
           };


            Department[] departments = new Department[]
            {
                new Department{Id=1,Name="Finance",Employees= emp1 },
                new Department{Id=2,Name="Marketing",Employees= emp2 },
                new Department{Id=3,Name="Human Resource",Employees= emp3 }
            };

            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.Id} {d.Name} ");
                foreach (Employee e in d.Employees)
                {
                    Console.WriteLine($"\t {e.Empid} -> {e.Name}");
                }

            }




        }

    }
}
