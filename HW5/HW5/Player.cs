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
        /// 決定是否復活怪獸
        /// </summary>
        /// <param name="mobs"></param>
        public void Revival(Mob mob)
        {
            UI.instance.LetItGo(mob.index);
            PlayerCmd playerCmd = new PlayerCmd();
            if (playerCmd.Cmd() == "5")
            {
                mob.states = 0;
                mob.hp = mob.maxHp;
                UI.instance.Revival(mob.index);
            }
            else
            {
                mob.states = 2;
                UI.instance.DeadMob(mob.index);
            }
        }
        /// <summary>
        /// 獲得物品
        /// </summary>
        /// <param name="index"></param>
        public void GetItem(int index)
        {
            Random random = new Random();
            bool boom = random.Next(0, 2) == 0;
            if (boom == true)
            {
                for (int i = 0; i < Data.instance.playerBag.bag.Length; i++)
                {
                    if (Data.instance.playerBag.bag[i] == 0)
                    {
                        Data.instance.playerBag.bag[i] = index;
                        break;
                    }
                }
                UI.instance.GetItem(index);
            }
        }
        /// <summary>
        /// 使用物品
        /// </summary>
        /// <returns></returns>
        public int UseItem()
        {
            int index = -1;
            return index;
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
