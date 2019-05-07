using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();

            for (int i = 0; i < 5; i++)
            {
                myLinkedList.AddLast(i);
            }

            Console.WriteLine("print nodes");
            myLinkedList.PrintNodes();
            Console.WriteLine($"count is {myLinkedList.Count}");
            myLinkedList.AddFirst(10);
            myLinkedList.PrintNodes();
            Console.WriteLine($"count is {myLinkedList.Count}");

            Console.WriteLine("Reversing....");
            LinkedList<int> reversed = myLinkedList.Reverse();
            reversed.PrintNodes();
        }
    }
}
