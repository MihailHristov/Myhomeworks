using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfPages
{
    class NumberOfPages
    {
        static void Main(string[] args)
        {
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;
            for (int page = 1;digits!=0 ; page++)//zapo4va se ot 1
                //digits!=0 razli4no ot 0,kogato e 0 cikula spira
            {
                pages++;
                if (page<10)
                {
                    digits -= 1;//брой на цифрите
                }
                else if (page<100)
                {
                    digits -= 2;
                }
                else if (page<1000)
                {
                    digits -= 3;
                }
                else if (page < 10000)
                {
                    digits -= 4;
                }
                else if (page < 100000)
                {
                    digits -= 5;
                }
                else if (page < 1000000)
                {
                    digits -= 6;
                }
            }
            Console.WriteLine(pages);
        }
    }
}
