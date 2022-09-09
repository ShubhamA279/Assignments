                    // ARITHMATIC TABLE                


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day04
{
    internal class Do_While_4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            do
            {
                Console.WriteLine($" {num} * {i} = {num * i}");

                i++;

            } while (i <= 10);

        }
    }
}
