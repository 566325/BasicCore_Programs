using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Perfect
    {
        public static void PerfectNumber() 
        {
            int Number, N, Sum = 0;
            Console.WriteLine("Enter the a Number");
            Number = Convert.ToInt32(Console.ReadLine());
            N = Number;
            for(int i = 1; i < Number; i++) 
            {
                if (Number % i == 0)
                {
                    Sum=Sum+i;
                }

            }
            if (Sum == N)
            {
                Console.WriteLine("It is a perfect Number");
            }
            else
            {
                Console.WriteLine("It ia Not a Perfect Number");
            }
        }
    }
}
