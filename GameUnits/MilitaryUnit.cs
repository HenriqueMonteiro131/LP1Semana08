using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit
    {
        
    }

    public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
    {
        AttackPower = attackPower;
        XP = 0;

    }
}
