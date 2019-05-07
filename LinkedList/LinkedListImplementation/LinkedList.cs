using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public LinkedList()
        {
            this.head = null;
        }

        public LinkedList(T value)
        {
            this.head = new Node<T>(value);
        }

        public int Count { get; private set; }

        public void AddFirst(T item)
        {
            Node<T> oldHead = this.head;

            this.head = new Node<T>(item);
            this.head.Next = oldHead;

            if (Count == 0)
            {
                this.tail = head;
            }

            this.Count++;
        }

        public void AddLast(T item)
        {
            if (head != null)
            {
                var currentHead = head;

                while (currentHead.Next != null)
                {
                    currentHead = currentHead.Next;
                }

                currentHead.Next = new Node<T>(item);
            }
            else
            {
                head = new Node<T>(item);
            }

            this.Count++;
        }

        public void RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new Exception("List is empty.");
            }

            this.head = this.head.Next;

            this.Count--;

            if (Count == 0)
            {
                this.tail = null;
            }
        }

        public void RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new Exception("List is empty.");
            }

            if (this.Count == 1)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                var currentHead = head;
                var secondToLast = head;

                while (currentHead.Next != null)
                {
                    secondToLast = currentHead;
                    currentHead = currentHead.Next;
                }

                secondToLast.Next = null;

                this.Count--;
            }
        }

        public void PrintNodes()
        {
            if (head != null)
            {
                var currentHead = head;

                while (currentHead.Next != null)
                {
                    Console.WriteLine(currentHead.Value);
                    currentHead = currentHead.Next;
                }

                Console.WriteLine(currentHead.Value);
            }
        }

        public LinkedList<T> Reverse()
        {
            LinkedList<T> reversed = new LinkedList<T>();

            if (this.Count == 0)
            {
                return reversed;
            }
            else
            {
                Node<T> current = head;

                List<T> elements = new List<T>();
                elements.Add(current.Value);

                while (current.Next != null)
                {
                    current = current.Next;
                    elements.Add(current.Value);
                }

                for (int i = elements.Count - 1; i >= 0; i--)
                {
                    reversed.AddLast(elements[i]);
                }

                return reversed;
            }
            
        }
    }
}
