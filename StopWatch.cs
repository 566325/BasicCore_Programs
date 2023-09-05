using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class StopWatch
    {
        public static void StartAndEndStopWatch()
        {
            int StartTime;
            int EndTime;
            int elapsed;
            Console.WriteLine("enter the StartTime");
            StartTime=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the StartTime");
            EndTime = Convert.ToInt32(Console.ReadLine());

            elapsed = StartTime - EndTime;
            Console.WriteLine(elapsed);



        }
    }
}
