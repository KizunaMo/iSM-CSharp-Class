using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class AxeWarriors : Player, IAttackBehavior
    {
        public AxeWarriors(IAttackBehavior attackBehavior,string name) : base(attackBehavior,name) { }
    }
}
