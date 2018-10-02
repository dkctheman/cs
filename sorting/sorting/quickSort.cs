using System;
using System.Collections.Generic;
using System.Text;

namespace sorting
{
    class quickSort
    {
        private int[] array;
        private int startInex;
        private int endIndex;

        public quickSort(int[] array)
        {
            this.array = array;
            startInex = 0;
            endIndex = array.Length - 1;
        }

       public int _pivot(int s, int e)
        {

            int p = array[s];

            int i = s+1;
            int j = e;
            int test = e;


            while (i < test)
            {
                while (array[i] < p)

                {
                    i++;
                }

                while (array[j] > p)
                {
                    j--;
                }

                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                Console.WriteLine("The pivot index{0},{1},{2},{3}", i, j, array[i], array[j]);
                test--;
            }

            array[s] = array[i];
            array[i] = p;
            Console.WriteLine("The pivot index{0},{1},{2},{3}", i,j,array[i],array[j]);
            return i;
            
   
        }

        public void _sort(int s, int e)
        {
            if ((e-s) <= 1)
            {
                return;
            }

            int p = _pivot(s, e);
            _sort(s, p);
            _sort(p + 1, e);



        }


        public void sort()
        {
            _sort(startInex, endIndex);
        }

    }
}
