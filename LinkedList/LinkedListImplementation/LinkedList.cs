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
            Node<T> oldTail = this.tail;

            this.tail = new Node<T>(item);
            oldTail.Next = this.tail;

            if (Count == 0)
            {
                this.head = tail;
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
                Node<T> newTail = this.GetSecondToLast();
                newTail.Next = null;
                this.tail = newTail;
                this.Count--;
            }
        }

        private Node<T> GetSecondToLast()
        {
            Node<T> current = this.head;

            while (current.Next != this.tail)
            {
                current = current.Next;
            }

            return current;
        }
    }
}
