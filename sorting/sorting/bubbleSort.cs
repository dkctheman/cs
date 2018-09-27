using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    class bubbleSort
    {
        private int[] array;
        public bubbleSort(int[] array)
        {
            this.array = array;
        }

        public void sort()
        {
            int length = array.Length-1;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (array[i] > array[i+1])
                    {
                        int temp = array[i];
                        array[i] = array[i+1];
                        array[i + 1] = temp;

                    }
                }
            }
        }

    }
}
