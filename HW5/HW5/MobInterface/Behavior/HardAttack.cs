using System;
using System.Collections.Generic;
using System.Text;

namespace HW5.MobInterface
{
    class HardAttack:IAttack
    {
        public void Attack()
        {
            Console.WriteLine($"使用重攻擊");
        }
    }
}
