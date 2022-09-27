using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Assignments.Day16
{

    public class Queue
    {

        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>();
            int[] arr = new int[10];
            queue.Enqueue(10);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);

            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------");
            queue.Enqueue(50);
            queue.Dequeue();
            queue.Dequeue();
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------");
            Console.WriteLine(queue.Peek());


            queue.CopyTo(arr, 0);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            queue.Clear();
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }

        }
    }

}
