using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit 
    {
        public int AttackPower { get; }
        public int XP { get; private set; }
    }

    public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
    {
        AttackPower = attackPower;
        XP = 0;

    }

   
}
