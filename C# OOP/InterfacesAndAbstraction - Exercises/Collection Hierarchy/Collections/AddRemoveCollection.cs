using Collection_Hierarchy.Interfaces;
using System.Collections.Generic;

namespace Collection_Hierarchy.Collections
{
    public class AddRemoveCollection<T> : AddCollection<T>, IRemovable<T>
    {
        public AddRemoveCollection()
        {
            base.collection = new List<T>();
        }

        public virtual T Remove()
        {
            T element = collection[collection.Count - 1];

            base.collection.RemoveAt(collection.Count - 1);

            return element;
        }

        public override int Add(T item)
        {
            collection.Insert(0, item);

            return 0;
        }
    }
}
