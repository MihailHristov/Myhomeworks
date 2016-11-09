using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    class Busses
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int groups = 0;
            int groupSpeed = int.MaxValue;//proverka za nai-visoka skorost
            for (int i = 0; i < count; i++)//cikul za duljinata 
            {
                int busSpeed = int.Parse(Console.ReadLine());
                //po vuvedeno chislo v koznolata se opredelq broq imame 3 busa izkarva 3 skorosti
                if (busSpeed<=groupSpeed)
                {
                    groups++;
                    groupSpeed = busSpeed;
                }
            }
            Console.WriteLine(groups);//izvun cikula
        }
    }
}
