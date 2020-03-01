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
                _swapCounter(firstValue, secondValue);
            }

            double tmp = firstValue;
            firstValue = secondValue;
            secondValue = tmp;
        }

        protected bool IsCompare(double firstValue, double secondValue)
        {
            if (_compareCounter != null)
            {
                _compareCounter(firstValue, secondValue);
            }

            return (firstValue > secondValue);
        }

        #region ======------ SUBSCRIBE/UNSUBSCRIBE METHODS ------=======

        public void SubscribeTimeStart(StartStopSorted source)
        {
            _startTime += source;
        }

        public void UnsubscribeTimeStart(StartStopSorted source)
        {
            _startTime -= source;
        }

        public void SubscribeTimeStop(StartStopSorted source)
        {
            _stopTime += source;
        }

        public void UnsubscribeTimeStop(StartStopSorted source)
        {
            _stopTime -= source;
        }

        public void SubscribeCompareCounter(SwapCompareCounter source)
        {
            _compareCounter += source;
        }

        public void UnsubscribeCompareCounter(SwapCompareCounter source)
        {
            _compareCounter -= source;
        }

        public void SubscribeSwapCounter(SwapCompareCounter source)
        {
            _swapCounter += source;
        }

        public void UnsubscribeSwapCounter(SwapCompareCounter source)
        {
            _swapCounter -= source;
        }

        #endregion
    }
}
