using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberProj
{
    class SwapCompareAnalyzer
    {
        #region =====----- PRIVATE DATA -----======

        private int _compareCounter = 0;
        private int _swapCounter = 0;
        private readonly Sorter _sorter = null;

        #endregion

        #region =====----- CTOR ------=====

        public SwapCompareAnalyzer(Sorter sorter)
        {
            _sorter = sorter;
        }

        #endregion

        #region =====----- PROPERTIES -----======

        public int SwapCount
        {
            get 
            {
                return _swapCounter; 
            }
        }

        public int CompareCount
        {
            get
            {
                return _compareCounter;
            }
        }

        #endregion

        public void Subscribe()
        {
            _sorter.SwapCounter += delegate(object sender, SwapCompareEventArgs args)
            {
                _swapCounter++;
            };

            _sorter.CompareCounter += delegate (object sender, SwapCompareEventArgs args)
            {
                _compareCounter++;
            };
        }

        public void Unsubscribe()
        {
            _sorter.SwapCounter -= delegate (object sender, SwapCompareEventArgs args)
            {
                _swapCounter++;
            };

            _sorter.CompareCounter -= delegate (object sender, SwapCompareEventArgs args)
            {
                _compareCounter++;
            };
        }
    }
}
