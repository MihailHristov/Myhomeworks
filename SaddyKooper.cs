using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SaddyKooper
{
    class SaddyKooper
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();//четене на число от конзолата//
            int transcount = 0;
            while (text.Length > 1&&transcount<10)
            {
                BigInteger product = 1;
                while (text.Length > 0) // докато дължината на input >0 извършвай операциите подолу
                {
                    text = text.Substring(0, text.Length - 1);// от въведена цифра в конзолата изважда най-дясната цифра  

                    int sum = 0;//сумата на четните цифри
                    for (int i = 0; i < text.Length; i += 2)// цикъл за намиране на цифри на четни позиции
                    {
                        sum += text[i] - '0';//char to string
                    }
                    product *= sum != 0 ? sum : 1;
                }
                transcount++;
                text = product.ToString();
            }
            if (transcount < 10)
            {
                Console.WriteLine(transcount);
            }
            Console.WriteLine(text);
        }
    }
}
