using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class SwordsMan : Player, IAttackBehavior
    {
        public int index { get; private set; } = 1;
        string profession = "劍士";
        public override string Profession { get => base.Profession; set => base.Profession = value; }
        int power = 100;
        public override int PowerDamage { get => base.PowerDamage; set => base.PowerDamage = value; }
        public SwordsMan(IAttackBehavior attackBehavior) : base(attackBehavior)
        {
            PowerDamage = power;
            Profession = profession;
        }


    }
}

