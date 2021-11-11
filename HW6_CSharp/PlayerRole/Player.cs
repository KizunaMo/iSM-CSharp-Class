using System;
using System.Collections.Generic;
using System.Text;
using HW6_CSharp.Mobs;

namespace HW6_CSharp.PlayerRole
{
    class Player : IAttackBehavior
    {
         string profession = "無職業";
        public virtual string Profession { get { return profession; } set { profession = value; } }
         int hp = 210;
        public int Hp { get { return hp; } set { hp = value; } }
         int maxHp = 300;
        public int MaxHp { get { return maxHp; } set { maxHp = value; } }
         int defultPower = 10;
        public virtual int PowerDamage { get { return defultPower; } set { defultPower = value; } }

        public Bag playerBag;


         IAttackBehavior attackBehavior;

        public Player(IAttackBehavior attackBehavior)
        {
            this.attackBehavior = attackBehavior;
            playerBag = new Bag(9,9);
        }

        public void Attack(Mob mob, int damage)
        {
            attackBehavior.Attack(mob,damage);
        }

        public void PrintStatus()
        {
            Console.WriteLine($"玩家資訊\n角色職業{profession}\n血量:{hp}\n攻擊力:{defultPower}");
        }

        public void BeAttack(int damage)
        {
            Hp -= damage;
            if (Hp <= 0)
                Hp = 0;
            Console.WriteLine($"玩家剩餘生命{Hp}");
        }

        public bool IsDead()
        {
            if (Hp <= 0)
                return true;
            return false;
        }

    }
}
