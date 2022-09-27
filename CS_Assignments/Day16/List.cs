using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day16
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id {Id} Name{Name}";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(100);
            list1.Add(20);
            list1.Insert(2, 30);
            list1.Add(20);
            list1.Add(40);
            list1.Add(60);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            list1.Reverse();
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");
            list1.RemoveAt(3);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");

            list1.IndexOf(40);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            list1.Remove(20);
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");
            list1.Count();

            Console.WriteLine("Count" + list1.Count());

            Console.WriteLine("----------");

            Console.WriteLine("Capacity" + list1.Capacity);

            List<Product> list2 = new List<Product>()
            {
                new Product{Id=14,Name="laptop"},
                new Product{Id=15,Name="Mobile"},
            };
            foreach (var item in list2)
            {
                Console.WriteLine($"{item}");
            }


            list1.Clear();
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }



        }
    }
}
