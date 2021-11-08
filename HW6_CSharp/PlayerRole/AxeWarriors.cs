using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class AxeWarriors : Player, IAttackBehavior
    {
        public int index { get; private set; } = 2;
        private string profession = "斧頭戰士";
        public override string Profession { get => base.Profession; set => base.Profession = value; }
        private int power = 150;
        public override int PowerDamage { get => base.PowerDamage; set => base.PowerDamage = value; }
        public AxeWarriors(IAttackBehavior attackBehavior) : base(attackBehavior) 
        {
            PowerDamage = power;
        }
    }
}
