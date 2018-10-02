using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    class print
    {

        public void show(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }

        }
    }
}
