using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class SwordsMan : Player, IAttackBehavior
    {

        private int Power = 100;
        public override int PowerDamage { get => base.PowerDamage; set => base.PowerDamage = value; }
        public SwordsMan(IAttackBehavior attackBehavior) : base(attackBehavior)
        {
            PowerDamage = Power;
        }


    }
}

