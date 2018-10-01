using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    class quickSort
    {
        private int[] array;

        public quickSort(int[] array)
        {
            this.array = array;
        }

        public void merge(int s1, int e1, int s2, int e2)
        {

            if (array[e1] < array[s2])
            {
                return;
            }

            for (int i = s2; i <= e2; i++)
            {
                for (int j = i; j > s1; j--)
                {
                    if (array[j-1] > array[j])
                    {
                        int temp = array[j-1];
                        array[j-1] = array[j];
                        array[j] = temp;
                    }
                }
            }


        }


    }
}
