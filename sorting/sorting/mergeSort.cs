using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    class mergeSort
    {
        private int[] array;
        private int startIndex;
        private int endIndex;

        public mergeSort(int[] array)
        {
            this.array = array;
            this.startIndex = 0;
            this.endIndex = array.Length - 1;
        }

        public void _merge(int s1, int e1, int s2, int e2)
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

        public void _sort(int s, int e)
        {
            

            if(s >= e)
            {
                return;
            }

            int mid = (s + e) / 2;

            _sort(s, mid);
            _sort(mid + 1, e);
            _merge(s, mid, mid + 1, e);




        }

        public void sort()
        {
            _sort(this.startIndex, this.endIndex);
        }


    }
}
