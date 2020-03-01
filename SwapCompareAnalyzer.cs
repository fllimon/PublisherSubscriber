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

        public void GetCompare(double firstValue, double secondValue)
        {
            _compareCounter++;
        }

        public void GetSwap(double firstValue, double secondValue)
        {
            _swapCounter++;
        }
    }
}
