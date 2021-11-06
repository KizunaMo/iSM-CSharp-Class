using System;
using System.Collections.Generic;
using System.Text;

namespace HW5.MobInterface
{
    class NoAttack:IAttack
    {
        public void Attack()
        {
            Console.WriteLine($"無法攻擊");
        }
    }
}
