using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoding
{
    class Decoding
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            int position= 0;//това са ни двата input-a
            while (true)
            {
                int charCode = Console.Read();
                char ch = (char)charCode;
                if (ch == '@') 
                {
                    break;
                }
                int newCode = 0;
                if (char.IsLetter(ch))//proverka za bukva ot a-do-z
                {
                    newCode = charCode * salt + 1000;
                }
                else if (char.IsDigit(ch)) //proverka dali tova e cifra 0-9
                {
                    newCode = charCode + salt + 500;
                }
                else
                {
                    newCode = charCode - salt;
                }
                if (position%2==0)
                {
                    Console.WriteLine("{0:F2}",newCode/100.0);/100.0 //получава се дробно число
                }
                else
                {
                    Console.WriteLine(newCode*100);
                }
                position++;
            }
            
        }
    }
}
