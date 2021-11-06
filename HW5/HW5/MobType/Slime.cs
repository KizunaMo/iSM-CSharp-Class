using System;
using System.Collections.Generic;
using System.Text;

namespace HW5.MobType
{
    class Slime:HW5.MobInterface.IAttack
    {

        public void Attack()
        {
            Console.WriteLine($"Slime Attack");
        }
    }
}
