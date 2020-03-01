using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberProj
{
    internal class BubbleSort : Sorter
    {
        public override double[] Sort()
        {
            double[] source = new double[DefaultSettings.DEFAULT_ARRAY_SIZE];

            source = (double[])_items.Clone();

            if (_startTime != null)
            {
                _startTime(DateTime.Now);
            }

            for (int i = 0; i < source.Length - 1; i++)
            {
                for (int j = 0; j < source.Length - 1; j++)
                {
                    if (IsCompare(source[i], source[i + 1]))
                    {
                        Swap(ref source[i], ref source[i + 1]);
                    }                    
                }
            }

            if (_stopTime != null)
            {
                _stopTime(DateTime.Now);
            }

            return source;
        }
    }
}
