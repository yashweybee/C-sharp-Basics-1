using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Intro
    {
        public void Greeting( string name)
        {
            Console.WriteLine("hello" + name);
        }

        

        public void passByValue(int val)
        {
            val += val;
            Console.WriteLine("insode fun: {0}", val);
        }

        public void passByRef(ref int val)
        {
            val += val;
            Console.WriteLine("insode fun: {0}", val);
        }

        public void funcOut(out int x, out int y)
        {
            x = 999;
            y = 8888;
        }



         static void Main(string[] args)
        {
            //int a = 10;
            //int b = 5;
            //int total = a + b;
            //if(b == 5)
            //{
            //    Console.Write("total {0} + {1} = {2}", a, b, total);

            //}
            //else
            //{
            //    Console.WriteLine("else statement");
            //}
            /****************************************************/

            //int num = 55;
            //if (num < 0 || num > 100)
            //{
            //    Console.WriteLine("wrong number");
            //}
            //else if (num >= 0 && num < 50)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else if (num >= 50 && num < 60)
            //{
            //    Console.WriteLine("D Grade");
            //}
            //else if (num >= 60 && num < 70)
            //{
            //    Console.WriteLine("C Grade");
            //}
            //else if (num >= 70 && num < 80)
            //{
            //    Console.WriteLine("B Grade");
            //}
            //else if (num >= 80 && num < 90)
            //{
            //    Console.WriteLine("A Grade");
            //}
            //else if (num >= 90 && num <= 100)
            //{
            //       Console.WriteLine("a+ grade");
            //}

            ///////////////////////////////////////////////////////
            //int num2 = 10;
            //switch (num2)
            //{
            //    case 10: 
            //        Console.WriteLine("It is 10"); 
            //        break;
            //    case 20: 
            //        Console.WriteLine("It is 20"); 
            //        break; 
            //    case 30:
            //        Console.WriteLine("It is 30");
            //        break;
            //    default:
            //        Console.WriteLine("Not 10, 20 or 30"); 
            //        break;
            //}
            /////////////////////////////////////////////
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);

            //}

            //for (; ; ) {
            //    Console.Write(10);
            //}

            //int j = 1;
            //while (j <= 10)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}

            Intro intro = new Intro();
            //intro.Greeting("Yash");
            int total = intro.sum(10, 20);
            Console.WriteLine(total);

            //int val = 10;
            //intro.passByValue(val);
            //Console.WriteLine(val);

            //intro.passByRef(ref val);
            //Console.WriteLine(val);

            //int a, b;
            //Console.WriteLine("before: {0}  {1}", a, b);
            //intro.funcOut(out a, out b);
            //Console.WriteLine("after: {0}  {1}", a, b);





            Console.ReadLine();
        }
        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}
