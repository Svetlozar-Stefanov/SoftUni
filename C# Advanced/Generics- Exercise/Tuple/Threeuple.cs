using System;
using System.Collections.Generic;
using System.Text;

namespace TupleAndThreeuple
{
    public class Threeuple<V1,V2,V3>
    {
        public V1 FirstValue { get; private set; }
        public V2 SecondValue { get; private set; }
        public V3 ThirdValue { get; private set; }
        public Threeuple(V1 v1, V2 v2,V3 v3)
        {
            FirstValue = v1;
            SecondValue = v2;
            ThirdValue = v3;
        }
    }
}
