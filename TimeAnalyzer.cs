using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherSubscriberProj
{
    class TimeAnalyzer
    {
        public void StartHandler(DateTime dateTime)
        {
            Console.WriteLine($"StartTime sort: {dateTime.Millisecond}");
        }

        public void StopHandler(DateTime dateTime)
        {
            Console.WriteLine($"StopTime sort: {dateTime.Millisecond}");
        }
    }
}
