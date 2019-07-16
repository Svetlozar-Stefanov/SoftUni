using Collection_Hierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Hierarchy.Collections
{
    class MyList<T> : AddRemoveCollection<T>, IDisplayable
    {
        public int Used
        {
            get
            {
                return collection.Count;
            }
        }

        public override T Remove()
        {
            T element = collection[0];

            collection.RemoveAt(0);

            return element;
        }
    }
}
