using System;

namespace PowToUntil
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                PowersOf2Until5();
            }
        }
        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
