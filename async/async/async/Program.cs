using System;
using System.Threading;
using System.Threading.Tasks;


namespace async
{
    class Program
    {
        private static int FindFactorialWithSimulatedDelay(int no)
        {
            int result = 1;
            for (int i = 1; i <= no; i++)
            {
                Thread.Sleep(500);
                result = result * i;
            }
            return result;
        }


        private async Task WriteFactorialAsyncUsingAwait(int facno)
        {
            int result = await Task.Run(() => FindFactorialWithSimulatedDelay(facno));
            Console.WriteLine("Factorial of {0} is {1}", facno, result);
        }


        public static void Main()
        {

            Program p = new Program();

            for (int counter = 1; counter < 5; counter++)
            {
                if (counter % 3 == 0)
                {
                    p.WriteFactorialAsyncUsingAwait(counter);
                    Console.WriteLine("just writing something");
                }
                else
                {
                    Console.WriteLine(counter);
                }
            }
            Console.ReadLine();
        }
    }
}
