using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day18
{
    internal class Zero_at_end
    {

        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 10, 0, 5, 3, 0, 4, 1 };

            int j = 0;

            for (int i = 0; i < arr.Length; i++)

            {

                if (arr[i] != 0)

                {

                    arr[j] = arr[i];

                    j++;

                }

            }

            for (int i = j; i < arr.Length; i++)

            {

                arr[i] = 0;

            }


            Console.WriteLine("after iteration:");
            foreach (var item in arr)

            {

                Console.Write(item + " ");

            }

        }










    }
}
