using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class Modifier
    {
        public double DateDifferance(DateTime date1, DateTime date2)
        {
            return Math.Abs((date1 - date2).TotalDays);
        }
    }
}
