using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            double mean = (a + b + c) / 3.0;
            int max = a;
            if (b>max)
            {
                max = b;
            }
            if (c>max)
            {
                max = c;
            }
            int min = a;
            if (b<min)
            {
                min = b;
            }
            if (c<min)
            {
                min = c;
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:F2}",mean);
        }
    }
}
