using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class Archer : Player, IAttackBehavior
    {
        public Archer(IAttackBehavior attackBehavior,string name) : base(attackBehavior,name) { }
    }
}
