using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class StopWatch
    {
        private string Elapsed;

        public static void StartAndEndStopWatch()
        {
            StopWatch stopWatch = new StopWatch();
            stopWatch.Start();
            for (int i = 0; i < 50000; i++)
            {
                Console.WriteLine(i);
            }
            stopWatch.Stop();
            Console.WriteLine("Time Elapsed:" + stopWatch.Elapsed);


        }

        private void Start()
        {
            throw new NotImplementedException();
        }

        private void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
