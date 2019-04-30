using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class MyQueue<T>
        where T : IComparable<T>
    {
        private List<T> items;

        public MyQueue()
        {
            this.items = new List<T>();
        }

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public void Dequeue()
        {
            items.RemoveAt(0);
        }

        public T Peek()
        {
            try
            {
                return items[0];
            }
            catch (Exception)
            {

                throw new Exception("Queue is empty!");
            }
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

        public void Clear()
        {
            items = new List<T>();
        }
    }
}
