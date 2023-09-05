using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FibonacciSeries
    {  
        public static void Fibonacci()
        {
            int a = 0, b =1,c, i, Number;
            Console.WriteLine("Enter a number");
            Number = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < Number;i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }


        }
    }
}
