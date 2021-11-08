using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.Mobs
{
    class Dragon : Mob
    {
        string name = "Dragon";
        public override string Name { get => base.Name; set => base.Name = value; }

        int hp = 1000;
        public override int Hp { get => base.Hp; set => base.Hp = value; }
        int power = 120;
        public override int Power { get => base.Power; set => base.Power = value; }


        public Dragon()
        {
            Name = name;
            Hp = hp;
            Power = power;
        }
        public override int Attack()
        {
            return Power;
        }
    }
}
