using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks myRoles = 0000;

            for(int i = 0; i < args.Length; i++)
            {
                Perks addRole = 0000;
                if (args[i] == "w")
                {
                    addRole = Perks.WatherBreathing;
                }
                else if (args[i] == "a")
                {
                    addRole = Perks.AutoHeal;
                }
                else if (args[i] == "s")
                {
                    addRole = Perks.Stealth;
                }
                else if (args[i] == "d")
                {
                    addRole = Perks.DoubleJump;
                }

                myRoles ^= addRole;
            }
            
            string allRoles = "";

            if ((myRoles & Perks.WatherBreathing) == Perks.WatherBreathing)
            { 
                allRoles += Perks.WatherBreathing.ToString(); 
                if ((myRoles ^= Perks.WatherBreathing) != 0)
                {
                    allRoles += ", ";
                }
            }
            if ((myRoles & Perks.Stealth) == Perks.Stealth)
            {
                allRoles += Perks.Stealth.ToString();
                if ((myRoles ^= Perks.Stealth) != 0)
                {
                    allRoles += ", ";
                }
            }
            if ((myRoles & Perks.AutoHeal) == Perks.AutoHeal)
            {
                allRoles += Perks.AutoHeal.ToString(); 
                if ((myRoles ^= Perks.AutoHeal) != 0)
                {
                    allRoles += ", ";
                }
            }
            if ((myRoles & Perks.DoubleJump) == Perks.DoubleJump)
            {
                allRoles += Perks.DoubleJump.ToString();
            }
        
            Console.WriteLine(allRoles);

            if ((myRoles & (Perks.Stealth & Perks.DoubleJump)) == (Perks.Stealth & Perks.DoubleJump))
            {
                Console.WriteLine("Silent Jumper!");
            }
            if ((myRoles & Perks.AutoHeal) == Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
