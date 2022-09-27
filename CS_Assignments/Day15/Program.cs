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
            ArrayList Students1 = new ArrayList();
            Students1.Add(new Student { StudName = "Rahul", City = "Mumbai" });
            Students1.Add(new Student { StudName = "Amit", City = "Pune" });

            ArrayList Students2 = new ArrayList();
            Students2.Add(new Student { StudName = "Yash", City = "Chiplun" });
            Students2.Add(new Student { StudName = "Darshan", City = "Nagpur" });


            ArrayList Students3 = new ArrayList();
            Students3.Add(new Student { StudName = "Ankit", City = "London" });
            Students3.Add(new Student { StudName = "Manish", City = "France" });


            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Course { Id = 1, Name = "C#", Fees = 10000, Students = Students1 });
            arrayList.Add(new Course { Id = 2, Name = "Java", Fees = 12000, Students = Students2 });
            arrayList.Add(new Course { Id = 3, Name = "MVC", Fees = 15000, Students = Students3 });



            foreach (Course c in arrayList)
            {
                Console.WriteLine($"{c.Id} {c.Name}  {c.Fees}");
                foreach (Student s in c.Students)
                {
                    Console.WriteLine($"\t {s.StudName} -> {s.City}");
                }

            }
            */

            
            ArrayList employee1 = new ArrayList();
            employee1.Add(new Employee1 { Empid = 1, Name = "Amit" });
            employee1.Add(new Employee1 { Empid = 5, Name = "Shubham" });

            ArrayList employee2 = new ArrayList();
            employee2.Add(new Employee1 { Empid = 7 , Name = "Ankit" });
            employee2.Add(new Employee1 { Empid = 14, Name = "Manish" });


            ArrayList employee3 = new ArrayList();
            employee3.Add(new Employee1 { Empid = 21, Name = "Rahul" });
            employee3.Add(new Employee1 { Empid = 30, Name = "Satej" });


            ArrayList arraylist = new ArrayList();
            arraylist.Add(new Department1 { Id = 1, Name = "Finance",  Employee = employee1 });
            arraylist.Add(new Department1 { Id = 2, Name = "Marketing",  Employee = employee2 });
            arraylist.Add(new Department1 { Id = 3, Name = "Human Resource",  Employee = employee3 });



            foreach (Department1 d in arraylist)
            {
                Console.WriteLine($"{d.Id} {d.Name} ");
                foreach (Employee1 e in d.Employee)
                {
                    Console.WriteLine($"\t {e.Empid} -> {e.Name}");
                }

            }
            


            /*
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
            */



        }

    }
}
