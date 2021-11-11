using HW6_CSharp.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.Mobs
{
    class Goblin : Mob
    {
        string name = "Goblin";
        public override string Name { get => base.Name; set => base.Name = value; }
        int hp = 300;
        public override int Hp { get => base.Hp; set => base.Hp = value; }
        int power = 60;
        public override int Power { get => base.Power; set => base.Power = value; }

        public Goblin()
        {
            Name = name;
            Hp = hp;
            Power = power;
        }

        public override int Attack()
        {
            return Power;
        }

        public override Item DropItem()
        {
            Item item = new AddPowerItem();
            Console.WriteLine($"掉落{item.Name}");
            return item;
        }
    }
}
