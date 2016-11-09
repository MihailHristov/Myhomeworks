using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardens
{
    class Gardens
    {
        static void Main(string[] args)
        {
            int tomatoseeds = int.Parse(Console.ReadLine());
            int tomatoarea = int.Parse(Console.ReadLine());
            int cucumberseeds = int.Parse(Console.ReadLine());
            int cucumberarea = int.Parse(Console.ReadLine());
            int potatoseeds = int.Parse(Console.ReadLine());
            int potatoarea = int.Parse(Console.ReadLine());
            int carrotseeds = int.Parse(Console.ReadLine());
            int carrotarea = int.Parse(Console.ReadLine());
            int cabbageseeds = int.Parse(Console.ReadLine());
            int cabbagearea = int.Parse(Console.ReadLine());
            int beansseeds = int.Parse(Console.ReadLine());
            double result = (tomatoseeds * 0.5 + cucumberseeds * 0.4 + potatoseeds * 0.25 + carrotseeds * 0.6 + cabbageseeds * 0.3 + beansseeds * 0.4);
            int beansarea = 250 - (tomatoarea + cucumberarea + potatoarea + carrotarea + cabbagearea);
            Console.WriteLine("Total costs:",result);
            if ((tomatoarea + cucumberarea + potatoarea + carrotarea + cabbagearea)<250)
            {
                Console.WriteLine("Beans area:",beansarea);
            }
            else if ((tomatoarea + cucumberarea + potatoarea + carrotarea + cabbagearea) > 250)
            {
                Console.WriteLine("Insufficient area");
            }
            else if  ((tomatoarea + cucumberarea + potatoarea + carrotarea + cabbagearea) == 250)
            {
                Console.WriteLine("No area for beans");
            }
        }
    }
}
