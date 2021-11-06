using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.Mobs
{
    class Goblin:Mob
    {
        private string name = "Goblin";
        public override string Name { get => base.Name; set => base.Name = value; }
        private int hp = 300;
        public override int Hp { get => base.Hp; set => base.Hp = value; }

        public Goblin()
        {
            Name = name;
            Hp = hp;
        }
    }
}
