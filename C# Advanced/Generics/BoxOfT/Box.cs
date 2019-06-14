using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> inner;
        public Box()
        {
            inner = new Stack<T>();
        }

        public int Count
        {
            get
            {
                return inner.Count;
            }
        }

        public void Add(T element)
        {
            inner.Push(element);
        }

        public T Remove()
        {
            return inner.Pop();
        }
    }
}
