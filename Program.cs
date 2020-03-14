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
            Sorter source = new BubbleSort();
            SwapCompareAnalyzer count = new SwapCompareAnalyzer(source);
            TimeAnalyzer time = new TimeAnalyzer(source);

            count.Subscribe();
            time.Subscribe();
            source.Sort();
            count.Unsubscribe();
            time.Unsubscribe();

            Console.WriteLine($"SwapCount: {count.SwapCount} --- CompareCount: {count.CompareCount}");

            Console.ReadKey();
        }
    }
}
