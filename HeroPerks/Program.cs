using System;
using System.ComponentModel;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPerks = args[0];
            

            Perks myRoles = 0000;

            foreach (char c in inputPerks)
            {
                Perks addRole = 0000;

                switch (c)
                {
                    case 'w':
                        addRole = Perks.WatherBreathing;
                        break;
                    case 'a':
                        addRole = Perks.AutoHeal;
                        break;
                    case 's':
                        addRole = Perks.Stealth;
                        break;
                    case 'd':
                        addRole = Perks.DoubleJump;
                        break;
                }

                myRoles ^= addRole;
            }
            
            string allRoles = "";

            bool isStealth = (myRoles & Perks.Stealth) == Perks.Stealth;
            bool isDoJump = (myRoles & Perks.DoubleJump) == Perks.DoubleJump;
            bool isAutoHeal = (myRoles & Perks.AutoHeal) == Perks.AutoHeal;

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

            

            if (isStealth && isDoJump)
            {
                Console.WriteLine("Silent Jumper!");
            }

            if (isAutoHeal == false)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
