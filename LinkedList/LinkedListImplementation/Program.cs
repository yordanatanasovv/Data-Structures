using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();

            for (int i = 0; i < 6; i++)
            {
                myLinkedList.AddFirst(i);
            }

            for (int i = 0; i < 6; i++)
            {
                myLinkedList.RemoveFirst();
            }

            for (int i = 0; i < 5; i++)
            {
                myLinkedList.AddLast(i);
            }

            for (int i = 0; i < 5; i++)
            {
                myLinkedList.RemoveLast();
            }
        }
    }
}
