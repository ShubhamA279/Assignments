//Find a contiguous subarray whose sum is equal to the given number. e.g. if the given array is { 12 ,4, 2, 10 , 5 , 1 } and the given number is 16 then the sum of subarray { 4,2,10} and
//{ 10, 5,1}, { 12,4} is equal to the given number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day12
{
    public class SumOfSubArray
    {

        public static void Subarray(int[] ar1, int num, int sum)
        {
            int currentsum, i, j, k;

            for (i = 0; i < num; i++)
            {
                currentsum = ar1[i];

                
                for (j = i + 1; j <= num; j++)
                {
                    if (currentsum == sum)
                    {
                    Console.WriteLine($" Sum found between indexes   : {i}   and   {j - 1}");
                    
                    Console.Write(" Printing the required subarray : ");
                    for (k = i; k <= j - 1; k++)
                      {
                            
                            Console.Write(ar1[k] +" ");
                      }
                        Console.WriteLine();

                    }
                    if (currentsum > sum || j == num)
                        break;
                    currentsum = currentsum + ar1[j];
                }
            }
            Console.WriteLine("No subarray found");
        }

        static void Main(string[] args)
        {
            int i, sum, num;
            //int[] ar1 = new int[num];
            Console.WriteLine("enter number of elements");
            num = Convert.ToInt32(Console.ReadLine());
            int[] ar1 = new int[num];

            Console.WriteLine("enter array ");
            for (i = 0; i < num; i++)
            {
                ar1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < num; i++)
            {
                Console.WriteLine(ar1[i]);
            }

            Console.WriteLine("enter sum value");
            sum = Convert.ToInt32(Console.ReadLine());

            Subarray(ar1, num, sum);

        }
    }
}
