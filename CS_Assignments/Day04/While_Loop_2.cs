//                Print even numbers between 1 to 20 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day04
{
    internal class While_Loop_2
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
                i++;
            }
        }
    }
}

