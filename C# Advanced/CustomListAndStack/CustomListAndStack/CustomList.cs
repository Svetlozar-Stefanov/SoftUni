using System;
using System.Collections.Generic;
using System.Text;

namespace CustomListAndStack
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] innerArray;

        public int Count { get; private set; } = 0;
        public int this[int index]
        {
            get
            {
                CheckRange(index);
                return innerArray[index];
            }
            set
            {
                CheckRange(index);
                innerArray[index] = value;
            }
        }
    
        public CustomList()
        {
            innerArray = new int[InitialCapacity];
        }

        public void Add(int element)
        {
            if (innerArray.Length <= Count)
            {
                Resize();
            }
            innerArray[Count] = element;
            Count++;
        }

        public int RemoveAt(int index)
        {
            CheckRange(index);
            int deletedElement = innerArray[index];
            innerArray[index] = default(int);
            ShiftToLeft(index);
            Count--;
            if (Count <= innerArray.Length / 4)
            {
                Shrink();
            }

            return deletedElement;
        }

        public void InsertAt(int index, int element)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (Count >= innerArray.Length)
            {
                Resize();
            }
            ShiftToRight(index);
            innerArray[index] = element;
            Count++;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            CheckRange(firstIndex);
            CheckRange(secondIndex);

            int temp = innerArray[firstIndex];
            innerArray[firstIndex] = innerArray[secondIndex];
            innerArray[secondIndex] = temp;
        }

        private void CheckRange(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void Resize()
        {
            int[] newArr = new int[innerArray.Length * 2];
            innerArray.CopyTo(newArr, 0);
            innerArray = newArr;
        }

        private void ShiftToLeft(int index)
        {
            CheckRange(index);
            for (int i = index; i < Count-1; i++)
            {
                innerArray[i] = innerArray[i + 1];
            }
            innerArray[Count - 1] = default(int);
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count - 1; i >= index; i--)
            {
                innerArray[i + 1] = innerArray[i];
            }
            innerArray[index] = default(int);
        }

        private void Shrink()
        {
            int[] newArr = new int[innerArray.Length / 2];

            innerArray.CopyTo(newArr, 0);
            innerArray = newArr;
        }

    }
}
