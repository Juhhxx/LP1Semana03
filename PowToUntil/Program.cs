using System;

namespace PowToUntil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        private static void PowerOf2Until5()
        {
            for (int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i)
            }
        }
    }
}
