using System;

namespace Question_3
{
    internal class Program
    {
        delegate void del(int[] arr);

        static void Main(string[] args)
        {
            del SumArr = (x) =>
            {
                int sum = 0;
                foreach (int i in x)
                    sum += i;
                Console.WriteLine(sum);
            };
            int[] testArray = {5, 7, 3, 2, 9};
            SumArr(testArray);
        }
    }
}
