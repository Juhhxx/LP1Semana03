using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myRoles = 0000;

            foreach (string input in args)
            {
                Perks addRole = 0000;

                if (input == "w")
                {
                    addRole = Perks.WatherBreathing;
                }
                else if (input == "a")
                {
                    addRole = Perks.AutoHeal;
                }
                else if (input == "s")
                {
                    addRole = Perks.Stealth;
                }
                else if (input == "d")
                {
                    addRole = Perks.DoubleJump;
                }

                myRoles ^= addRole;
            }
            

            if ((myRoles & Perks.WatherBreathing) == Perks.WatherBreathing)
            { 
                Console.WriteLine(Perks.WatherBreathing);   
            }
            if ((myRoles & Perks.Stealth) == Perks.Stealth)
            {
                Console.WriteLine(Perks.Stealth);
            }
            if ((myRoles & Perks.AutoHeal) == Perks.AutoHeal)
            {
                Console.WriteLine(Perks.AutoHeal);
            }
            if ((myRoles & Perks.DoubleJump) == Perks.DoubleJump)
            {
                Console.WriteLine(Perks.DoubleJump);
            }
        }
    }
}
