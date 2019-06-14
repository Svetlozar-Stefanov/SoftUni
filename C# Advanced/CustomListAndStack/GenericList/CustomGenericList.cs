using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    public class CustomGenericList<T>
    {
        private const int InitialCapacity = 2;
        private T[] innerArray;

        public int Count { get; private set; } = 0;
        public T this[int index]
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

        public CustomGenericList()
        {
            innerArray = new T[InitialCapacity];
        }

        public void Add(T element)
        {
            if (innerArray.Length <= Count)
            {
                Resize();
            }
            innerArray[Count] = element;
            Count++;
        }

        public T RemoveAt(int index)
        {
            CheckRange(index);
            T deletedElement = innerArray[index];
            innerArray[index] = default(T);
            ShiftToLeft(index);
            Count--;
            if (Count <= innerArray.Length / 4)
            {
                Shrink();
            }

            return deletedElement;
        }

        public void InsertAt(int index, T element)
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

            T temp = innerArray[firstIndex];
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
            T[] newArr = new T[innerArray.Length * 2];
            innerArray.CopyTo(newArr, 0);
            innerArray = newArr;
        }

        private void ShiftToLeft(int index)
        {
            CheckRange(index);
            for (int i = index; i < Count - 1; i++)
            {
                innerArray[i] = innerArray[i + 1];
            }
            innerArray[Count - 1] = default(T);
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count - 1; i >= index; i--)
            {
                innerArray[i + 1] = innerArray[i];
            }
            innerArray[index] = default(T);
        }

        private void Shrink()
        {
            T[] newArr = new T[innerArray.Length / 2];

            innerArray.CopyTo(newArr, 0);
            innerArray = newArr;
        }

    }
}
