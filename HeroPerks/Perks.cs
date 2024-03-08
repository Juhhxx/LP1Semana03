using System;

namespace HeroPerks
{
    [Flags]
    enum HeroPerks
    {
        WatherBreathing = 'w',
        Stealth = 's',
        AutoHeal = 'a',
        DoubleJump = 'd'
    }
}