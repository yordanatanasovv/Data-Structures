﻿using System;

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

            Console.WriteLine("printing nodes");
            myList.PrintNodes();
            Console.WriteLine($"Count - {myList.Count}");

            Console.WriteLine("Remove last element: ");
            myList.RemoveLast(); 
            myList.PrintNodes();
            Console.WriteLine($"Count - {myList.Count}");

            Console.WriteLine("Remove first element: ");
            myList.RemoveFirst();
            myList.PrintNodes();
            Console.WriteLine($"Count - {myList.Count}");
        }
    }
}
