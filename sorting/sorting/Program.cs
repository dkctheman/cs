using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            const int MIN = 0;
            const int MAX = 100;
            int length = 10;
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(MIN, MAX);

            }

            bubbleSort bs = new bubbleSort(array);
            bs.sort();

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
            

            Console.WriteLine("Hello World!");
        }


    }
}
