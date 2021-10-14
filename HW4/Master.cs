using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class Master
    {
        public int index { set; get; }
        public int hp { set; get; }
        public int exp { set; get; }
        public int maxHp { get; } = 1000;
        public int states { set; get; }//怪物狀態(0滿血 / 1失血 / 2死亡)
       
        public int MaxHp()
        {
            return maxHp;
        }
        public Master()
        {

        }
        public void Injured(int damage)
        {
            if (damage > hp)
            {
                this.hp = 0;
                Console.WriteLine("ATTACK 造成力量值" + damage + "傷害", "\n死亡");
            }
            else
            {
                Console.WriteLine("ATTACK 造成力量值" + damage + "傷害");
                this.hp -= damage;
            }
        }

    }
}
