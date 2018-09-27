using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int length = 10000;
            int[] array = new int[length];
            p.randArray(array, 0, 1000000000);
            Console.WriteLine("------before----------");
            p.print(array);
            Console.WriteLine("------after----------");
            bubbleSort bs = new bubbleSort(array);
            bs.sort();
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
