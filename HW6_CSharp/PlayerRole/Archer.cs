using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class Archer : Player, IAttackBehavior
    {
        public int index { get; private set; } = 3;
        string profession = "弓箭手";
        public override string Profession { get => base.Profession; set => base.Profession = value; }
        int power = 90;
        public override int PowerDamage { get => base.PowerDamage; set => base.PowerDamage = value; }
        public Archer(IAttackBehavior attackBehavior) : base(attackBehavior)
        {
            PowerDamage = power;
            Profession = profession;
        }
    }
}
