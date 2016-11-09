using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    class Birds
    {
        static void Main(string[] args)
        {
            double birds = double.Parse(Console.ReadLine());
            double feathers = double.Parse(Console.ReadLine());
            double result = 0;
            double average = (feathers / (double)birds);
            if (birds==0&&feathers==0)
            {
                Console.WriteLine(result);
            }
            else if (birds%2==0)
            {
                result = average * 123123123123;
            }
            else
            {
                result =average/317;
            }
            Console.WriteLine("{0:f4}",result);
        }
    }
}
