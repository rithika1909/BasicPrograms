using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class FlipCoin
    {
        public void Play() 
        {
            Random random = new Random();
            Console.WriteLine("Enter no of times the coin needed to flipped");
            int num = Convert.ToInt32(Console.ReadLine());
            int headCount =0, tailCount =0;
            for (int i=0;i<num; i++)
            {
                double check = random.NextDouble();
                if (check < 0.5)
                    tailCount++;
                else
                    headCount++;
            }
            Console.WriteLine("percentage of Head" + " " + (headCount / num) * 100);
            Console.WriteLine("percentage of Tail" + " " + (tailCount / num) * 100);
        }
    }
}
