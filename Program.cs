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

            source.StartTime += time.StartHandler;
            source.StopTime += time.StopHandler;
            source.SwapCounter += count.GetSwap;
            source.CompareCounter += count.GetCompare;
            source.Sort();

            Console.WriteLine($"SwapCount: {count.SwapCount} --- CompareCount: {count.CompareCount}");

            source.StartTime -= time.StartHandler;
            source.StopTime -= time.StopHandler;
            source.SwapCounter -= count.GetSwap;
            source.CompareCounter -= count.GetCompare;

            Console.ReadKey();
        }
    }
}
