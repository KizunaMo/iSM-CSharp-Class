using HW6_CSharp.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.Mobs
{
    class Slime : Mob
    {
        string name = "Slime";
        public override string Name { get => base.Name; set => base.Name = value; }
        int hp = 60;
        public override int Hp { get => base.Hp; set => base.Hp = value; }


        public Slime()
        {
            Name = name;
            Hp = hp;
        }

        public override int Attack()
        {
            return base.Power;
        }

        public override Item DropItem()
        {
            Item item = new HealItem();
            Console.WriteLine($"掉落{item.Name}");
            return item;
        }

    }
}
