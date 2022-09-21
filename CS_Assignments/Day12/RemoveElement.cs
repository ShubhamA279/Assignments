//Remove a given element from an array.  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day12
{
    public class RemoveElement
    {
        static void Main(string[] args)
        {
            int size, loc, i;

            Console.WriteLine("enter array size");
            size = Convert.ToInt32(Console.ReadLine());

            int[] ar1 = new int[size];
            Console.WriteLine("enter array element");

            for (i = 0; i < size; i++)
            {
                ar1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("array elements are");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(ar1[i]);
            }

            Console.WriteLine("enter array location to delete element");
            loc = Convert.ToInt32(Console.ReadLine());
            for (i = loc; i < size - 1; i++)
            {
                ar1[i] = ar1[i + 1];
            }
            size--;

            Console.WriteLine("array after deletion");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(ar1[i] + " ");
            }

        }
    }
}
