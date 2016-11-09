using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_preparation
{
    class Squiralls
    {
        static void Main(string[] args)
        {
            double tree = double.Parse(Console.ReadLine());
            double branches = double.Parse(Console.ReadLine());
            double squiralls = double.Parse(Console.ReadLine());
            double tails = double.Parse(Console.ReadLine());
            double result = (double)(tree * branches * squiralls * tails);
            if (result%2==0)
            {
                Console.WriteLine("{0:f3}", result*376439);
            }
            else
            {
                Console.WriteLine("{0:f3}", result /7);
            }

        }
    }
}
