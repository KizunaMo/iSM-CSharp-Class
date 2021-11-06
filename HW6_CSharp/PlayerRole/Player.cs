using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class Player : IAttackBehavior
    {
        private int defultPower = 10;
        public virtual int PowerDamage { get { return defultPower; } set { defultPower = value; } }

        private IAttackBehavior attackBehavior;

        public Player(IAttackBehavior attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }

        public void Attack()
        {
            attackBehavior.Attack();
        }

    }
}
