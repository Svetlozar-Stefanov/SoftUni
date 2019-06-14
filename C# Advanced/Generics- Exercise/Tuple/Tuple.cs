using System;
using System.Collections.Generic;
using System.Text;

namespace TupleAndThreeuple
{
    public class Tuple<V1,V2>
    {
        public V1 FirstValue { get; private set; }
        public V2 SecondValue { get; private set; }

        public Tuple(V1 v1, V2 v2)
        {
            FirstValue = v1;
            SecondValue = v2;
        }
    }
}
