using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class ReverseNumber
    {
        public static void Reverse_a_Number() 
        {
            int n;
            int reverse = 0;
            int number;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                number = n % 10;
                reverse = reverse * 10 + number;
                n = n / 10;


            }
            Console.WriteLine("Reverse number = " + reverse);

        }
    }
}
