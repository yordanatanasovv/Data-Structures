using System;
using System.Collections;
using System.Collections.Generic;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {  
            MyStack<int> myStack = new MyStack<int>();

            for (int i = 0; i < 10; i++)
            {
                myStack.Push(i);
            }

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine(stack.Peek());
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }
    }
}
