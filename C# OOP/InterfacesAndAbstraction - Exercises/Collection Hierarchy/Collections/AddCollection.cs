using Collection_Hierarchy.Interfaces;
using System.Collections.Generic;

namespace Collection_Hierarchy.Collections
{
    public class AddCollection<T> : IAddable<T>
    { 
        protected List<T> collection;

        public AddCollection()
        {
            collection = new List<T>();
        }
        public virtual int Add(T item)
        {
            collection.Add(item);

            return collection.Count - 1;
        }
    }
}
