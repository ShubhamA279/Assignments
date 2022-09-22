using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day12
{
    public class demo
    {
        static void Main(string[] args)
        {
            //int[] arr = { 10, 20, 30, 40, 50, 60, 70 };
            //int mid = (arr.Length + 1) / 2;

            //int[] first = new int[mid];
            //int[] second = new int[arr.Length - mid];

            //Array.Copy(arr, 0, first, 0, mid);
            //Array.Copy(arr, mid, second, 0, second.Length);

            //foreach (var i in second)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("------------");
            //foreach (var irem in first)
            //{
            //    Console.WriteLine(irem);
            //}


            int i, n, a, j;

            //printf("Enter the value of n\n");
            Console.WriteLine("enter n");
            //scanf("%d", &n);
            n=Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            // printf("enter the numbers\n");
            Console.WriteLine("enter nums");
            for (i = 0; i < n; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //scanf("%d", &number[i]);

            //printf("Enter the position of the element to split the array \n");
            Console.WriteLine("position");
           //scanf("%d", &a);
           a= Convert.ToInt32(Console.ReadLine());  

            for (i = 0; i < a; ++i)
            {

                arr[n] = arr[0];
                for (j = 0; j < n; ++j)
                {
                    arr[j] = arr[j + 1];
                }

            }

            //printf("The resultant array is\n");
            Console.WriteLine("resultant rayy");

            for (i = 0; i < n; ++i)
            {
                //printf("%d\n", number[i]);
                Console.WriteLine(arr[i]);
            }









        }
    }
}
