using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class Player:IAttackBehavior
    {
        private string name = "Noname";

        private IAttackBehavior attackBehavior;

        public Player(IAttackBehavior attackBehavior,string name)
        {
            this.attackBehavior = attackBehavior;
            this.name = name;
        }

        public void Attack()
        {
            attackBehavior.Attack();
        }

    }
}
