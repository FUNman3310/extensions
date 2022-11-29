using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    static class Palidrom
    {
        public static void PalidromOrNot(this int num)
        {
            int r, palidrom = 0, t;
            
            for (t = num; num != 0; num = num / 10)
            {
                r = num % 10;
                palidrom = palidrom * 10 + r;
            }
            if (t == palidrom)
                Console.Write("this is a palindrome number.\n", t);
            else
            {
                Console.Write("this is not a palindrome number.\n", t);
            }
        }
    }
}
