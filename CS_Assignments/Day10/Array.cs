using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day10
{
    internal class Array
    {
        static void Main(string[] args)
        {
            string[] str = new string[5];

            Console.WriteLine("enter names");

            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            Console.WriteLine("==================================");

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
