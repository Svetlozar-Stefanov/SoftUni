using System;
using System.Collections.Generic;
using System.Text;

namespace P01._Square_Before
{
    public class Square : Shape
    {
        public int Side { get;private set; }

        public override double Area => Side * Side;
    }
}
