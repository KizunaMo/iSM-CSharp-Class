using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class Mob
    {
        public int index { set; get; }
        public int hp { set; get; }
        public int maxHp {set; get; }
        public int exp { set; get; }
        public int states { set; get; }//怪物狀態(0滿血 / 1失血 / 2死亡)
        /// <summary>
        /// 怪獸狀態 對應 states列印中文
        /// </summary>
        public enum States
        {
            滿血,
            失血,
            死亡,
        }
        public enum DropItems
        {
            什麼都沒有 = 0,
            炸彈 = 1,
        }
        /// <summary>
        /// 怪物受到傷害後回傳bool 確認是否血量低於0
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="mobs"></param>
        /// <returns></returns>
        public bool Injured(int damage, Mob mobs)
        {
            mobs.hp -= damage;
            if (mobs.hp <= 0)
            {
                mobs.hp = 0;
                mobs.states = 2;
                Console.WriteLine("造成" + damage + "傷害" + "\n怪物血量歸0");
                return true;
            }
            else
            {
                mobs.states = 1;
                Console.WriteLine("造成" + damage + "傷害" + "\n怪物剩餘血量:" + mobs.hp);
            }
            return false;
        }

        public int DropItem(int itemIndex)
        {
            int index = 1;
            return index;
        }

    }
}
