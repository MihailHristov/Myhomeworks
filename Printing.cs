using System;

namespace Printing
{
    class Printing
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double papers = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double totalsheets= students * papers;
            double reams = totalsheets/ 500;
            double result = reams * price;
            Console.WriteLine("{0:f2}", result);
        }
    }
}


