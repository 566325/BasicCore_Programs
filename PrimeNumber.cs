using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeNumber
    {
        public static void AllPrimeNumbers() 
        {
            int n, a=0,b=0, i;
            Console.WriteLine("Enter Number to Check it is a Prime Number");
            n= Convert.ToInt32(Console.ReadLine());
            a = n / 2;
            for(i = 2; i <= a; i++)
            {
                if(n% i == 0) 
                {
                    Console.WriteLine("It Is Not a Prime Number");
                    b=1; 
                    break;
                }
            }
            if(b == 0)
            {
                Console.WriteLine("It is  a Prime Number");
            }
                

            
        }
    }
}
