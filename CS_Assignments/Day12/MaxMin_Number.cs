using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day12
{
    public class MaxMin_Number
    {
        static void Main(string[] args)
        {
            int[] num = new int[10]
            { 1, 2, 5, 4, 3, 9, 8, 6, 10, 7 };

            Array.Sort(num);
            Console.WriteLine("after sort array elements");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Minimum num:" + num[0]);
            Console.WriteLine("Maximum num:" + num[num.Length - 1]);

        }
    }
}
