using System;

namespace Question_2
{
    internal class Program
    {
        delegate void del(int x1, int x2);

        static void Main(string[] args)
        {
            del AddTwoNums = (x1, x2) => Console.WriteLine(x1 + x2);
            AddTwoNums(15, 16);
        }
    }
}
