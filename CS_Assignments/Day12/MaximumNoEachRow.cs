//Find maximum number from each row of two dimensional array with dimensions ( 3 x 4)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CS_Assignments.Day12
{
    public class MaximumNoEachRow
    {
        static void Main(string[] args)
        {
            int i, j;
            // int[,] result = new int[2, 0];
            int[] max = new int[20];
            int[,] ar1 = new int[3, 4];
            Console.WriteLine("Enter array Elements");
            for (i = 0; i < ar1.GetLength(0); i++)  //Row
            {
                for (j = 0; j < ar1.GetLength(1); j++) //Column
                {
                    ar1[i,j]=Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("------------------");
            Console.WriteLine("array element are:");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write(ar1[i, j] + " ");
                }
                Console.WriteLine();

            }

            for (i = 0; i < 3; i++)
            {

                max[i] = ar1[i,0];

                for (j = 0; j < 4; j++)
                {
                    if (ar1[i, j] > max[i])
                    {
                        max[i] = ar1[i, j];
                    }
                }
            }
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine($"Maximum element of the row {i} is:  {max[i]}");
            }
        }
    }
}
