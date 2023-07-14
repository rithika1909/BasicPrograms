using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class QuotientRemainder
    {
        public void PrintQuotientRemainder()
        {
            int quot = 0, rem = 0;
            Console.WriteLine("Enter first num : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sec num : ");
            int y = Convert.ToInt32(Console.ReadLine());
            quot = x / y;
            rem = x % y;
            Console.WriteLine("Quotitent is " + quot);
            Console.WriteLine("Remainder is " + rem);
        }
    }
}
