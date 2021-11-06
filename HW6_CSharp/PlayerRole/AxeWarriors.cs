using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class AxeWarriors : Player, IAttackBehavior
    {
        private int power = 150;
        public override int PowerDamage { get => base.PowerDamage; set => base.PowerDamage = value; }
        public AxeWarriors(IAttackBehavior attackBehavior) : base(attackBehavior) 
        {
            PowerDamage = power;
        }
    }
}
