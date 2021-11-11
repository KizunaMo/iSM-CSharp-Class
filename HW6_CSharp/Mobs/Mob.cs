using System;
using System.Collections.Generic;
using System.Text;
using HW6_CSharp.Items;

namespace HW6_CSharp.Mobs
{
    class Mob
    {
        string name = "";
        public virtual string Name { get { return name; } set { name = value; } }

        int hp = 0;
        public virtual int Hp { get { return hp; } set { hp = value; } }

        int power = 30;
        public virtual int Power { get { return power; } set { power = value; } }


        public void PrintStatus()
        {
            Console.WriteLine($"怪物種類 : {name}\n 血量:{hp}\n 怪物攻擊力{power}");
        }

        public bool isDead()
        {
            if (hp <= 0)
            {
                hp = 0;
                return true;
            }
            return false;
        }

        public virtual int Attack()
        {
            return Power;
        }

        public virtual Item DropItem()
        {
            Item item = new Item();
            return item;
        }
    }
}
