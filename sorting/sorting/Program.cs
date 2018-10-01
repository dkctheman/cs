﻿using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //int[] array = { 7, 8, 3, 10, 1, 2, 9, 4 };
            int length = 10;
            int[] array = new int[length];
            p.randArray(array, 0, 10000);
            Console.WriteLine("------before----------");
            p.print(array);
            Console.WriteLine("------after----------");
            //bubbleSort bs = new bubbleSort(array);
            //bs.sort();
            mergeSort q = new mergeSort(array);
            q.sort();
            p.print(array);            

            Console.WriteLine("Hello World!");
        }

        void print(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }

        }

        void randArray(int[] array, int min, int max)
        {
            Random rand = new Random();
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(min, max);

            }

        }


    }
}
