using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int index;

        public ListyIterator(List<T> collection)
        {
            this.collection = collection;
            index = 0;
        }

        public bool Move()
        {
            bool result = false;
            if (HasIndex())
            {
                index++;
                result = true;
            }
            return result;
        }

        public bool HasIndex()
        {
            return index + 1 < collection.Count;
        }

        public void Print()
        {
            if (collection.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
                return;
            }
            Console.WriteLine(collection[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return internalIEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerator<T> internalIEnumerator()
        {
            for (int i = 0; i < collection.Count; i++)
            {
                yield return collection[i];
            }
        }
    }
}
