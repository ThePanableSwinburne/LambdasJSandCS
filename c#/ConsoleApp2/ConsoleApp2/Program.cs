using System;

namespace Question_1
{
    internal class Program
    {
        delegate void WelcomeDelegate(string pName);

        static void Main(string[] args)
        {
            WelcomeDelegate Welcome = (x) => Console.WriteLine(x);
            Welcome("John");
        }
    }
}
