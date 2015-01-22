using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringMethods
{
    public enum FilterTypes
    {
        Median, Average
    }

    public class FilterFactory
    {

        public static Filter CreateFilter(FilterTypes type, int lenght)
        {
            Filter filter = null;
            switch (type)
            {
                case FilterTypes.Average:
                    filter = new AverageFilter(lenght);
                    break;

                case FilterTypes.Median:
                    filter = new MedianFilter(lenght);
                    break;

                default:
                    // throw some exception
                    break;
            }
            return filter;
        }

    }
}
