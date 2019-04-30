using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myLinkedList = new LinkedList<int>(0);

            for (int i = 1; i < 5; i++)
            {
                myLinkedList.AddLast(i);
            }

            Console.WriteLine("print nodes");
            myLinkedList.PrintNodes();
            Console.WriteLine($"count is {myLinkedList.Count}");
            myLinkedList.AddFirst(10);
            myLinkedList.PrintNodes();
            Console.WriteLine($"count is {myLinkedList.Count}");

            Console.WriteLine("===== start removing ====");
            myLinkedList.RemoveFirst();
            myLinkedList.RemoveFirst();
            myLinkedList.RemoveFirst();

            myLinkedList.PrintNodes();

            Console.WriteLine("==== remove last ====");
            myLinkedList.RemoveLast();
            myLinkedList.PrintNodes();


            //for (int i = 0; i < 6; i++)
            //{
            //    myLinkedList.RemoveFirst();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    myLinkedList.AddLast(i);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    myLinkedList.RemoveLast();
            //}
        }
    }
}
