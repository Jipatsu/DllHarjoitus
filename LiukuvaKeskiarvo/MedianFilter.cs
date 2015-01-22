using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilteringTools
{
    public class MedianFilter : Filter
    {
        public MedianFilter(int length)
            : base(length)
        {

        }

        public override double Calculate()
        {
            List<double> tmp = base.buffer.ToList();
            tmp.Sort();
            return tmp[tmp.Count / 2];
        }
    }
}
