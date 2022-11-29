using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    static class Find
    {
        public static int MatchCount(this string name,string refind)
        {
            
            int count = 0;
            string[] parts = name.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i]==refind)
                {
                   count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
