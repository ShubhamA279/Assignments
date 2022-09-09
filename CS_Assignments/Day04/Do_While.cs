//                Print numbers from 1 to 50

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day04
{
    internal class Do_While
    {
        static void Main(string[] args)
        {


            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 50);
        }
    }
}
