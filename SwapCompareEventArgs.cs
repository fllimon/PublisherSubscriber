using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberProj
{
    class SwapCompareEventArgs : EventArgs
    {
        public double SwapCounter { get; private set; }

        public double CompareCounter { get; private set; }

        public SwapCompareEventArgs(double swapCounter, double compareCounter)
        {
            SwapCounter = swapCounter;
            CompareCounter = compareCounter;
        }
    }
}
