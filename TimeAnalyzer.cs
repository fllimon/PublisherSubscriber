using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberProj
{
    class TimeAnalyzer
    {
        private readonly Sorter _sorter = null;

        public TimeAnalyzer(Sorter sorter)
        {
            _sorter = sorter;
        }

        public void Subscribe()
        {
            _sorter.StartTime += delegate (object sender, StartStopSortedEventArgs args)
            {
                Console.WriteLine($"StartTime sort: {args.Time.Millisecond}");
            };

            _sorter.StopTime += delegate (object sender, StartStopSortedEventArgs args)
            {
                Console.WriteLine($"StartTime sort: {args.Time.Millisecond}");
            };
        }

        public void Unsubscribe()
        {
            _sorter.StartTime -= delegate (object sender, StartStopSortedEventArgs args)
            {
                Console.WriteLine($"StartTime sort: {args.Time.Millisecond}");
            };

            _sorter.StopTime -= delegate (object sender, StartStopSortedEventArgs args)
            {
                Console.WriteLine($"StartTime sort: {args.Time.Millisecond}");
            };
        }
    }
}
