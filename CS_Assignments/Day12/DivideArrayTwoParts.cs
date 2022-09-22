/*
Divide array in two parts and reverse the two parts. e.g. 
    if array is { 1,2,3,4,5,6,} result should be { 4,5,6, 1,2,3}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CS_Assignments.Day12
{
    public class DivideArrayTwoParts
    {

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            int k = 3;
            Console.WriteLine($"Array Length:{arr.Length}");

            for (int i = 0; i < arr.Length; i = i + k)
            {
                int start = i;
                int end = Math.Min(i + k - 1, arr.Length - 1);


                while (start <= end)
                {
                    int temp = arr[start];
                    arr[start] = arr[end];
                    arr[end] = temp;
                    start++;
                    end--;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }



        }
    }
}
