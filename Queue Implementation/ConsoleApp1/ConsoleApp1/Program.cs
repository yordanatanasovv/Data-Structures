using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);

            Console.WriteLine(queue.Peek());

            Console.WriteLine("---------------");
            
            MyQueue<int> myQueue = new MyQueue<int>();

            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            myQueue.Enqueue(7);
            myQueue.Enqueue(8);

            Console.WriteLine(myQueue.Peek());

        }
    }
}
