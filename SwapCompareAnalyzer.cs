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

        public void GetCompare(object sender, SwapCompareEventArgs args)
        {
            _compareCounter++;
        }

        public void GetSwap(object sender, SwapCompareEventArgs args)
        {
            _swapCounter++;
        }
    }
}
