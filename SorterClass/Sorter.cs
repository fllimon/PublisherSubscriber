using System;
using System.Collections;

using PublisherSubscriberProj.Delegate;

namespace PublisherSubscriberProj
{
    abstract class Sorter 
    {
        #region =====----- PROTECTED DATA -----======

        protected double[] _items;
        protected StartStopSorted _startTime;
        protected StartStopSorted _stopTime;
        protected SwapCompareCounter _swapCounter;
        protected SwapCompareCounter _compareCounter;

        #endregion

        #region =====----- CTOR

        public Sorter()
        {
            _items = new double[DefaultSettings.DEFAULT_ARRAY_SIZE];
            GetRandomInitialize();
        }

        #endregion

        #region ======------ EVENTS ------======

        public event StartStopSorted StartTime
        {
            add
            {
                _startTime += value;
            }
            remove
            {
                _startTime -= value;
            }
        }

        public event StartStopSorted StopTime
        {
            add
            {
                _stopTime += value;
            }
            remove
            {
                _stopTime -= value;
            }
        }

        public event SwapCompareCounter SwapCounter
        {
            add
            {
                _swapCounter += value;
            }
            remove
            {
                _swapCounter -= value;
            }
        }

        public event SwapCompareCounter CompareCounter
        {
            add
            {
                _compareCounter += value;
            }
            remove
            {
                _compareCounter -= value;
            }
        }

        #endregion

        private void GetRandomInitialize() 
        {
            Randomyzer rnd = Randomyzer.GetInstance();

            for (int i = 0; i < _items.Length; i++)
            {
                rnd.GetRandomInitialize(_items);
            }
        }

        public abstract double[] Sort();

        protected void Swap(ref double firstValue, ref double secondValue)
        {
            if (_swapCounter != null)
            {
                _swapCounter(this, new SwapCompareEventArgs(firstValue, secondValue));
            }

            double tmp = firstValue;
            firstValue = secondValue;
            secondValue = tmp;
        }

        protected bool IsCompare(double firstValue, double secondValue)
        {
            if (_compareCounter != null)
            {
                _compareCounter(this, new SwapCompareEventArgs(firstValue, secondValue));
            }

            return (firstValue > secondValue);
        }
    }
}
