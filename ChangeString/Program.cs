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
            string charc = Console.ReadLine();
            char c = char.Parse(charc);

            Console.WriteLine("");

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == c)
                {
                    Console.Write("X");
                }
                else
                {      
                    Console.Write(s[i]);
                }
            }
        }
    }
}
