using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    class SwordsMan : Player, IAttackBehavior
    {
        public SwordsMan(IAttackBehavior attackBehavior,string name) : base(attackBehavior,name) { }

    }
}
