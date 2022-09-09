//               Odd numbers from 100 to 50


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day04
{
    internal class While_Loop_3
    {
        static void Main(string[] args)
        {
            int i = 100;

            while (i >= 50)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                i--;

            }
        }

    }
}
