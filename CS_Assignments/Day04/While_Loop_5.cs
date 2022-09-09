//      Print numbers divisible by 5 from 1 to 100


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day04
{
    internal class While_Loop_5
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 100)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

    }
}


    

