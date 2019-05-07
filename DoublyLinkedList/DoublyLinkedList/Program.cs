using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            DoublyLinkedList<int> myList = new DoublyLinkedList<int>();

            for (int i = 0; i < 5; i++)
            {
                myList.AddFirst(i);
            }

            Console.WriteLine("Printing nodes");
            myList.PrintNodes();
            Console.WriteLine($"Count - {myList.Count}");

            Console.WriteLine("Removing first element");
            myList.RemoveFirst();
            myList.PrintNodes();
            Console.WriteLine($"Count - {myList.Count}");

            Console.WriteLine("Removing last element");
            myList.RemoveLast();
            myList.PrintNodes();
            Console.WriteLine($"Count - {myList.Count}");

            Console.WriteLine("Reversing...");
            DoublyLinkedList<int> reversed = myList.Reverse();
            reversed.PrintNodes();
            
            

        }
    }
}
