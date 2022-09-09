using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day04
{
    internal class Pattern_2
    {
        static void Main(string[] args)
        {

            // PATTERN
            /* 54321
             * 5432
             * 543
             * 54
             * 5
             */
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }
}
