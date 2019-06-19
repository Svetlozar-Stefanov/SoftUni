using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> innerPath;

        public Lake(int[] path)
        {
            innerPath = path.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return IternalIEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator<int> IternalIEnumerator()
        {
            for (int i = 0; i < innerPath.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return innerPath[i];
                }
            }

            for (int i = innerPath.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return innerPath[i];
                }
            }
        }
    }
}
