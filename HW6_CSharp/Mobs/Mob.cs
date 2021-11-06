using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.Mobs
{
    class Mob
    {
        private string name = "";
        public virtual string Name { get { return name; } set { name = value; } }

        private int hp = 0;
        public virtual int Hp { get { return hp; } set { hp = value; } }

    }
}
