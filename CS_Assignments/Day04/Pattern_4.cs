using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day04
{
    internal class Pattern_4
    {
        static void Main(string[] args)
        {
            //PATTERN
            /*
             * A
             * AB
             * ABC
             * ABCD
             * ABCDE
             */
             
             
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0}", Convert.ToChar(j + 64));
                }
                Console.WriteLine();
            }
        }
    }
}
