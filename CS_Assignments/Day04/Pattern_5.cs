using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day04
{
    internal class Pattern_5
    {
        static void Main(string[] args)
        {

            /*
                    *
                   * *
                  * * *
                 * * * *
             */

            int i, j,k;
            for (i = 1; i <= 4; i++)
            {
                for (j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                for(k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
              

                

            }
        }
    }
}
