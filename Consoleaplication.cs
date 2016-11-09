using System;
using System.Numerics;

namespace ConsoleApplication1
{
    class Consoleaplication
    {
        static void Main()
        {
            int index = 0;
            BigInteger globalProduct = 1;

            while (true)//докато не получим end четем стрингове
            {
                var line = Console.ReadLine();
                if (line == "END") 
                {
                    break;
                }
                if (index == 10) //проверка колко числа сме достигнали
                {
                    Console.WriteLine(globalProduct);
                    globalProduct = 1;
                }
                long num = long.Parse(line);
                if (index % 2 == 1) 
                {
                   long product = 1;
                    while (num > 0) 
                    {
                        long digit = num % 10;//взимане последната цифра на дадено число
                        if (digit != 0) 
                        {
                             product = product * digit;
                        }
                        num /= 10;
         
                    }
                    globalProduct = globalProduct * product;
                }
                
                index = index + 1;
            }
            Console.WriteLine(globalProduct);
        }
    }
}
