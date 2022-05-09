using System;

namespace Question_4
{
    internal class Program
    {
        delegate void del(int baseNum, int exponent);

        static void Main(string[] args)
        {
            del power = (b, e) =>
            {
                int sum = b;
                for (int i = 0; i < e - 1; i++)
                {
                    sum *= b;
                }
                Console.WriteLine(sum);
            };
            power(3, 2);
        }
    }
}
