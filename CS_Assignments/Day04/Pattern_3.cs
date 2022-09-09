using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day04
{
    internal class Pattern_3
    {
        static void Main(string[] args)
        {

            // PATTERN
            /*
             * 12345
             * 2345
             * 345
             * 45
             * 5
             * */

            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = i; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
        }
    }
}
