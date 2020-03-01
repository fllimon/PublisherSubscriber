using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberProj
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapCompareAnalyzer count = new SwapCompareAnalyzer();
            TimeAnalyzer time = new TimeAnalyzer();
            Sorter source = new BubbleSort();

            source.SubscribeTimeStart(time.StartHandler);
            source.SubscribeTimeStop(time.StopHandler);
            source.SubscribeSwapCounter(count.GetSwap);
            source.SubscribeCompareCounter(count.GetCompare);
            source.Sort();
            source.UnsubscribeTimeStart(time.StartHandler);
            source.UnsubscribeTimeStop(time.StopHandler);
            source.UnsubscribeSwapCounter(count.GetSwap);
            source.UnsubscribeCompareCounter(count.GetCompare);

            Console.ReadKey();
        }
    }
}
