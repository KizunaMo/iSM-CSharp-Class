using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class Archer : Player, IAttackBehavior
    {
        private int power = 90;
        public override int PowerDamage { get => base.PowerDamage; set => base.PowerDamage = value; }
        public Archer(IAttackBehavior attackBehavior) : base(attackBehavior) 
        {
            PowerDamage = power;
        }
    }
}
