using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Next { get; internal set; }

        public Node(T value)
        {
            this.Value = value;
        }
    }
}
