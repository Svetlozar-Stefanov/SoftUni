using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> innerCollection;

        public CustomStack()
        {
            innerCollection = new List<T>();
        }
        public void Push(T element)
        {
            innerCollection.Add(element);
        }

        public T Pop()
        {
            if (innerCollection.Count == 0)
            {
                Console.WriteLine("No elements");
                return default(T);
            }

            T removedElement = innerCollection[innerCollection.Count - 1];
            innerCollection.RemoveAt(innerCollection.Count - 1);
            return removedElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return IternalIEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator<T> IternalIEnumerator()
        {
            for (int i = innerCollection.Count - 1; i >= 0; i--)
            {
                yield return innerCollection[i];
            }
        }
    }
}
