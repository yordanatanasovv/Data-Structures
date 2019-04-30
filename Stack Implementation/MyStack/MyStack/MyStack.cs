using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    public class MyStack<T>
        where T : IComparable<T>
    {
        private List<T> items;

        public MyStack()
        {
            items = new List<T>();
        }

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Peek()
        {
            try
            {
                return items[items.Count - 1];
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
        }

        public T Pop()
        {
            var poppedItem = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return poppedItem;   
        }

        public void Clear()
        {
            items = new List<T>();
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].CompareTo(item) == 0) 
                {
                    return true;
                }
            }

            return false;
        }
    }
}
