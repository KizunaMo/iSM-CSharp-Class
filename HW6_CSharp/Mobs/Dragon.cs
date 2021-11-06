using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.Mobs
{
    class Dragon:Mob
    {
        private string name = "Dragon";
        public override string Name { get => base.Name; set => base.Name = value; }

        private int hp = 1000;
        public override int Hp { get => base.Hp; set => base.Hp = value; }

        public Dragon()
        {
            Name = name;
            Hp = hp;
        }
    }
}
