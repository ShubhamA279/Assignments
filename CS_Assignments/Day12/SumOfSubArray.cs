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

        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("enter size of array");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr1 = new int[size];
            Console.WriteLine("enter element of array");

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("enter reqired sum");

            int reqsum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array created is :");
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("subarray whose sum is:" + reqsum);

            for (int i = 0; i < arr1.Length; i++) //5
            {
                int sum = 0;
                for (int j = i; j < arr1.Length; j++)
                {
                    sum = sum + arr1[j];
                    if (reqsum == sum)
                    {
                        for (int k = i; k <= j; k++)
                        {
                            Console.Write($"{arr1[k]} ");


                        }
                        Console.WriteLine();
                        //Console.WriteLine($"{arr1 },{i},{j+1}");
                        // perfect
                        //Console.Write($" indexes where sum found is :{i},{j}");

                    }

                }
            }

        }
    }
}
