using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> _objects;
        public Stack()
        {
            _objects = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj != null)
                _objects.Insert(0, obj);
            else
                throw new InvalidOperationException("Cannot push null into stack.");
        }
        public object Pop()
        {
            if (_objects.Count > 0)
            {
                var value = _objects[0];
                _objects.RemoveAt(0);
                return value;
            }
            else
                throw new InvalidOperationException("The stack is empty.");
        }
        public void Clear()
        {
            _objects.Clear();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            int n = 10;
            for (int i = 1; i <= n; i++)
                stack.Push(i);

            Console.WriteLine("Current stack:");
            for (int i = 0; i < n; i++)
                Console.WriteLine(stack.Pop());
        }
    }
}
