using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayPractice
    {
        static void arrayPrint( int[] arr)
        {
            arr[0] = 999;
            foreach (int k in arr)
            {
                Console.WriteLine(k);
            }
        }

        static void printArr(int[] arr)
        {
            foreach (int k in arr)
            {
                Console.WriteLine(k);

            }

        }

        static void multiPera(params int[] myParams)
        {
            for(int i = 0; i < myParams.Length; i++)
            {
                //Console.WriteLine(myParams[i]);
            }

        }
        public static void Main(string[] args)
        {

            int[] arr1 = new int[5];
            for (int i = 0; i < 3; i++)
            {
                arr1[i] = i;
            }

            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //int[] arr2 = new int[1];

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            //arrayPrint( arr2);

            //foreach (int j in arr2)
            //{
            //    Console.WriteLine(j);
            //}

            /*int[,] arr2d = { { 1, 2 }, { 2, 3 }, { 3, 4 } };*/
            //Console.WriteLine(arr2d[0, 1]);
            int[,] arr2d = new int[3, 4];
            //for(int i = 0;i< arr2d.GetLength(0); i++)
            //{
            //    for (int j = 0;j< arr2d.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr2d[i, j]);
            //    }
            //}


            int[][] jaggedArr = new int[2][];
            jaggedArr[0] = new int[2]{1,2};
            jaggedArr[1] = new int[4]{3,6,3,2};
            /*Console.WriteLine(jaggedArr[0][1]);*/

            int[][] jaggedArr2 = new int[5][]
            {
                new int[2]{1,2},
                new int[5] {4,7,3,9,1},
                new int[1],
                new int[3]{1,4,2},
                new int[2]{1,2}
            };

            //Console.WriteLine(jaggedArr2[1][1]);

            multiPera(10,40,30,20);
            int[] animal = new int[3];

            int[] customers = { 10, 20, 40, 50, 23 };


            //Console.WriteLine(customers.Rank);
            //Console.WriteLine(customers.IsReadOnly);
            //Console.WriteLine(customers.IsFixedSize);
            //Console.WriteLine(customers.Length);

            int[] animals2 = animal.Clone() as int[];
            Array.Copy(customers, animals2,animal.Length);

            //Console.WriteLine(animals2[0]);
            //printArr(animals2);

            //Console.WriteLine(Array.IndexOf(customers,40));

            //Array.Sort(customers);

            //printArr(customers);

            //Console.WriteLine(customers.ToString());

            Console.WriteLine("Argument length: " + args.Length);
            Console.WriteLine("Supplied Arguments are:");
            foreach (Object obj in args)
            {
                Console.WriteLine(obj);
            }



            Console.ReadLine();
        }
    }
}
