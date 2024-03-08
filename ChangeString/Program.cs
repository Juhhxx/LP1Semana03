using System;

namespace ChangeString
{
    class Program
    {
        static void Main()
        {
            Console.Write("Insira uma string: ");
            string s = Console.ReadLine();

            Console.Write("\nInsira uma letra para ser substituída: ");
            string c = Console.ReadLine();

            // string[] newStringAr = new string[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
            }
        }
    }
}
