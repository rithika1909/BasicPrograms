using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class LargestNumber
    {
        public void FindLargestNum()
        {
            

            Console.Write("Input the 1st number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (b > c)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }
    }
}
