using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            int total = a + b;
            if(b == 5)
            {
              Console.Write("total {0} + {1} = {2}", a, b, total);

            }
            else
            {
                Console.WriteLine("else statement");
            }
            /****************************************************/

            int num = 55;
            if (num < 0 || num > 100)
            {
                Console.WriteLine("wrong number");
            }
            else if (num >= 0 && num < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine("D Grade");
            }
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C Grade");
            }
            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Grade");
            }
            else if (num >= 90 && num <= 100)
            {
                Console.WriteLine("A+ Grade");
            }




            Console.ReadLine();
        }
    }
}
