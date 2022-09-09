//               Odd numbers from 100 to 50

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day04
{
    internal class Do_While_3
    {
        static void Main(string[] args)
        {
            int i = 100;

            do
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
                i--;

            } while (i >= 50);
        }
    }
}
