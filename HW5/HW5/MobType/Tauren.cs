using System;
using System.Collections.Generic;
using System.Text;
using HW5.MobInterface;

namespace HW5.MobType
{
    class Tauren:IAttack
    {
        public void Attack()
        {
            Console.WriteLine($"Tauren Attack");
        }
    }
}
