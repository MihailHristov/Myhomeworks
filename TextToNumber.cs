using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToNumber
{
    class TextToNumber
    {
        static void Main(string[] args)
        {
            int module = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            text = text.ToLower();
            long result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];// с масив се ползва дължината на i

                if (ch == '@')
                {
                    break;
                }
                else if ('0' <= ch && ch <= '9') //if char is digit
                {
                    result *= (ch - '0');
                }
                else if ('a' <= ch && ch <= 'z') //if char is letter
                {
                    result += (ch - 'a');
                
                }
                else
                {
                    result %= module;
                }
            }

            Console.WriteLine(result);
        }
    }
}
