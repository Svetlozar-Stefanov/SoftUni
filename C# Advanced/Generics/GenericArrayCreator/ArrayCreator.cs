using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    static public class ArrayCreator
    { 
        static public T[] Create<T>(int length, T item)
        {
            T[] newArr = new T[length];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = item;
            }
            return newArr;
        }
    }
}
