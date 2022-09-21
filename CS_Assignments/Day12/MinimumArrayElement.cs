using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day12
{
    public class MinimumArrayElement
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] ar = new int[3, 3];
            Console.WriteLine("enter array elements");
            for ( i = 0; i < ar.GetLength(0); i++)
            {
                for ( j = 0; j < ar.GetLength(1); j++)
                {
                    ar[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("-------------------");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(ar[i, j] + " ");
                }
                Console.WriteLine();
            }
            int max, min;
            max = min = ar[0, 0];

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (max < ar[i, j])
                    {
                        max = ar[i, j];
                    }
                    if (min > ar[i, j])
                    {
                        min = ar[i, j];
                    }
                }
            }
            Console.WriteLine("max element : " + max);
            Console.WriteLine("min element : " + min);

        }
    }
}
