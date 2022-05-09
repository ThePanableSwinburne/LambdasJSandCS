using System;

namespace Question_5
{
    internal class Program
    {
        delegate void del(int num);

        static void Main(string[] args)
        {
            del fib = (n) =>
            {
                int firstnumber = 0, secondnumber = 1, result = 0;

                if (n == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                if (n == 1)
                {
                    Console.WriteLine(1);
                    return;
                }

                for (int i = 2; i <= n; i++)
                {
                    result = firstnumber + secondnumber;
                    firstnumber = secondnumber;
                    secondnumber = result;
                }

                Console.WriteLine(result);

            };
            fib(10);
        }
    }
}

