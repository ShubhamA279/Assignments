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

        static void ReverseArray(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        // Function to print an array
        static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
        }

        
        static void SplitArr(int[] arr, int k, int n)
        {
            ReverseArray(arr, 0, n - 1);
            ReverseArray(arr, 0, n - k - 1);
            ReverseArray(arr, n - k, n - 1);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6 };
            int n = arr.Length;
            int k ;
            Console.WriteLine("enter the position to divide array:");
            k=Convert.ToInt32(Console.ReadLine());
            // Function calling
            SplitArr(arr, k, n);
            PrintArray(arr, n);
        }
    }
}
