using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.PlayerRole
{
    interface IAttackBehavior
    {
        void Attack();
    }

    public class NoWeapon : IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine($"赤手攻擊");
        }
    }

    public class SwordsAttck:IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine("使用劍攻擊");
        }
    }

    public class AxeAttack : IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine("使用斧頭攻擊");
        }
    }

    public class Arcger : IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine("使用弓箭攻擊");
        }
    }

}
