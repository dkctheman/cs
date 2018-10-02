using System;

namespace dt
{
    class Program
    {
        static void Main(string[] args)
        {

            list l = new list();
            int length = 10;
            int min = 0;
            int max = 100;
            int[] array = new int[length];
            Random r = new Random();

            for (int i = 0; i < length; i++)
            {
                int temp = r.Next(min, max);
                l.add(temp);
                array[i] = temp;
            }

            l.print();
            l.remove(array[4]);
            l.print();
            l.add(88);
            l.print();
            


            Console.WriteLine("Hello World!");
        }
    }
}
