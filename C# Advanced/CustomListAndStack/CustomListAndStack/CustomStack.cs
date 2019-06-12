using System;
using System.Collections.Generic;
using System.Text;

namespace CustomListAndStack
{
    public class CustomStack
    {
        private const int InitialCapacity = 4;

        private int[] innerArr;

        public int Count { get; private set; } = 0;


        public CustomStack()
        {
            innerArr = new int[InitialCapacity];
        }

        public void Push(int element)
        {
            if (Count >= innerArr.Length)
            {
                Resize();
            }
            innerArr[Count] = element;
            Count++;
        }

        public int Pop()
        {
            if (innerArr.Length == 0)
            {
                throw new InvalidOperationException();
            }
            int element = innerArr[Count - 1];
            innerArr[Count- 1] = default(int);
            Count--;

            return element;
        }

        public int Peek()
        {
            if (innerArr.Length == 0)
            {
                throw new InvalidOperationException();
            }
            int element = innerArr[Count -1 ];

            return element;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(innerArr[i]);
            }
        }

        private void Resize()
        {
            int[] newArr = new int[innerArr.Length * 2];
            innerArr.CopyTo(newArr, 0);
            innerArr = newArr;
        }
    }
}
