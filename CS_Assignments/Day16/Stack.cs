using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day16
{
    public class Stack
    {

        static void Main(string[] args)
        {

            Stack<int> stack = new Stack<int>();
            int[] arr = new int[10];
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);
            stack.Push(13);

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------");
            stack.Push(50);
            stack.Pop();
            stack.Pop();
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------");
            Console.WriteLine(stack.Peek());

            Console.WriteLine("-----------------");
            stack.CopyTo(arr, 0);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            stack.Clear();
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

        }

    }
}
