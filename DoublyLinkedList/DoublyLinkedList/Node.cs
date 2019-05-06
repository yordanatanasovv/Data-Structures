using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    public class Node<T>
    {
        public T Value { get; internal set; }

        public Node<T> Next { get; internal set; }

        public Node<T> Previous { get; internal set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }
}
