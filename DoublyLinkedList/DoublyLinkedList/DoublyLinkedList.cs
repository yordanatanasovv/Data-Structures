using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private Node<T> head;

        public DoublyLinkedList()
        {
            this.head = null;
        }

        public DoublyLinkedList(T value)
        {
            this.head = new Node<T>(value);
            Count++;
        }

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            if (Count == 0)
            {
                this.head = new Node<T>(value);                
            }
            else
            {
                Node<T> oldHead = head;
                head = new Node<T>(value);
                head.Next = oldHead;
                oldHead.Previous = head;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            if (Count == 0)
            {
                head = new Node<T>(value);
            }
            else
            {
                Node<T> currentElement = head;

                while (currentElement.Next != null)
                {
                    currentElement = currentElement.Next;
                }

                Node<T> lastElement = new Node<T>(value);
                currentElement.Next = lastElement;
                lastElement.Previous = currentElement;
            }

            Count++;
        }

        public void RemoveFirst()
        {
            if (Count == 0)
            {
                throw new Exception("List is empty.");
            }
            else
            {
                Node<T> elementToRemove = head;

                if (head.Next != null)
                {
                    head = head.Next;
                    head.Previous = null;
                }
                else
                {
                    head = null;
                }

                Count--;
            }
        }

        public void RemoveLast()
        {
            if (Count == 0)
            {
                throw new Exception("List is empty.");
            }
            else
            {
                Node<T> currentElement = head;
                Node<T> beforeLast = head;

                while (currentElement.Next != null)
                {
                    beforeLast = currentElement;
                    currentElement = currentElement.Next;
                }

                beforeLast.Next = null;
                Count--;
            }
        }

        public void PrintNodes()
        {
            if (Count != 0)
            {
                Node<T> currentElement = head;

                while (currentElement.Next != null)
                {
                    Console.WriteLine(currentElement.Value);
                    currentElement = currentElement.Next;
                }

                Console.WriteLine(currentElement.Value);
            }
        }

        public DoublyLinkedList<T> Reverse()
        {
            DoublyLinkedList<T> reversed = new DoublyLinkedList<T>();

            if (Count == 0)
            {
                throw new Exception("List is empty.");
            }
            else
            {
                Node<T> current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                Node<T> lastElement = current;
                reversed.AddFirst(lastElement.Value);

                while (lastElement.Previous != null)
                {
                    lastElement = lastElement.Previous;
                    reversed.AddLast(lastElement.Value);
                }

                return reversed;
            }
        }
    }
}
