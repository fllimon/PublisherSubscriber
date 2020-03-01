using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberProj
{
    internal class ShakerSort : Sorter
    {
        public override double[] Sort()
        {
            double[] array = new double[DefaultSettings.DEFAULT_ARRAY_SIZE];
            array = (double[])_items.Clone();

            if (_startTime != null)
            {
                _startTime(DateTime.Now);
            }

            for (int i = 0; i < array.Length / 2; i++)
            {
                bool swapFlag = false;

                for (int j = i; j < array.Length - i - 1; j++)
                {
                    int minValue = i;

                    if (IsCompare(array[j], array[minValue]))
                    {
                        minValue = j;
                    }
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                        swapFlag = true;
                    }
                }

                for (int j = array.Length - 2 - i; j > i; j--)
                {
                    int minValue = i;

                    if (IsCompare(array[j], array[minValue]))
                    {
                        minValue = j;
                    }
                    if (array[j - 1] > array[j])
                    {

                        Swap(ref array[j - 1], ref array[j]);

                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

            if (_stopTime != null)
            {
                _stopTime(DateTime.Now);
            }

            return array;
        }
    }
}
