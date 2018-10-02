using System;
using System.Collections.Generic;
using System.Text;

namespace dt
{
    class list
    {
        private int a;
        list next;

        public list()
        {
            this.next = null;

        }

        public list(int a)
        {
            list temp = new list();
            temp.a = a;
            temp.next = null;
            this.next = temp;
        }


        public void add(int a)
        {
            list temp = new list();
            temp.a = a;
            temp.next = null;
            list current = this;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = temp;
        }

        public void remove (int a)
        {
            list current = this;

            while (current.next != null)
            {
                if(current.next.a == a)
                {
                    current.next = current.next.next;
                    return;
                }

                current = current.next;
            }

        }

        public void print()
        {
            list current = this.next;
            while (current != null)
            {
                Console.WriteLine("{0}",current.a);
                current = current.next;
            }
            Console.WriteLine("---------------");
        }

    }
}
