using System;
using System.Collections.Generic;
using System.Text;
using HW6_CSharp.Mobs;

namespace HW6_CSharp.PlayerRole
{
    interface IAttackBehavior
    {
        void Attack(Mob mob,int damage);
    }

    public class NoWeapon : IAttackBehavior
    {
        void IAttackBehavior.Attack(Mob mob, int damage)
        {
            mob.Hp -= damage;
            if (mob.Hp <= 0)
                mob.Hp = 0;
            Console.WriteLine($"赤手攻擊 怪物血量剩餘{mob.Hp}");
        }
    }

    public class SwordsAttck:IAttackBehavior
    {
        void IAttackBehavior.Attack(Mob mob, int damage)
        {
            mob.Hp -= damage;
            mob.isDead();
            Console.WriteLine($"使用劍攻擊 怪物血量剩餘{mob.Hp}");
        }
    }

    public class AxeAttack : IAttackBehavior
    {
        void IAttackBehavior.Attack(Mob mob, int damage)
        {
            mob.Hp -= damage;
            mob.isDead();
            Console.WriteLine($"使用斧頭攻擊 怪物血量剩餘{mob.Hp}");
        }
    }

    public class ArcgerAttack : IAttackBehavior
    {
        void IAttackBehavior.Attack(Mob mob, int damage)
        {
            mob.Hp -= damage;
            mob.isDead();
            Console.WriteLine($"使用弓箭攻擊 怪物血量剩餘{mob.Hp}");
        }
    }

}
