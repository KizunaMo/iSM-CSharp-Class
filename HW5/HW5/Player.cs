using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class Player
    {
        public static Player instance;
        public int power { set; get; } = 300;
        public int exp { set; get; } = 0;

        private void MakeSingleton()
        {
            if (instance == null)
                instance = this;
        }

        public Player()
        {
            MakeSingleton();
        }

        public void Attack(Mob mob)
        {
            mob.hp -= power;
        }
        /// <summary>
        /// 復活怪獸
        /// </summary>
        /// <param name="mobs"></param>
        public void Revival(Mob mob)
        {
            mob.states = 0;
            mob.hp = mob.maxHp;
        }
        /// <summary>
        /// 是否獲得物品
        /// </summary>
        /// <param name="index"></param>
        public bool GetItem(int index)
        {
            Random random = new Random();
            bool getItem = random.Next(0, 2) == 0;
            if (getItem == true)
            {
                for (int i = 0; i < Data.instance.playerBag.bag.Length; i++)
                {
                    if (Data.instance.playerBag.bag[i] == 0)
                    {
                        Data.instance.playerBag.bag[i] = index;
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// 使用物品
        /// </summary>
        /// <returns></returns>
        public void UseItem(int itemIndex)
        {
            for (int i = 0; i < Data.instance.playerBag.bag.Length; i++)
            {
                if (Data.instance.playerBag.bag[i] == itemIndex)
                {
                    Data.instance.playerBag.bag[i] = 0;
                }
            }
        }
        /// <summary>
        /// 玩家獲得經驗值
        /// </summary>
        /// <param name="mob"></param>
        public void GetExp(Mob mob)
        {
            exp += mob.exp;
        }
    }
}
