using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class HarmonicNumber
    {
        public void PrintHarmonicNumber()
        {
            Console.WriteLine("Enter the value of n: ");
            int n =Convert.ToInt32(Console.ReadLine());
            float x = 0, y;
            for (float i=1;i<=n;i++)
            {
                y = 1 / i;
                x = x + y;
            }
            Console.WriteLine("nth harmonic number :" + " " + x);
        }
    }
}
