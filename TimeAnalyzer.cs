using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberProj
{
    class TimeAnalyzer
    {
        public void StartHandler(object sender, StartStopSortedEventArgs args)
        {
            Console.WriteLine($"StartTime sort: {args.Time.Millisecond}");
        }

        public void StopHandler(object sender, StartStopSortedEventArgs args)
        {
            Console.WriteLine($"StopTime sort: {args.Time.Millisecond}");
        }
    }
}
