using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW5
{
    class Data
    {
        public static Data instance;

        public Player player = new Player();
        public Bag playerBag = new Bag();
        public Mob[] mobs = new Mob[10];
        public List<Mob> deadMobs = new List<Mob>();
        public Items items = new Items();


        public Data()
        {
            MakeSingleton();
            ProduceNormalMaster();
        }

        private void MakeSingleton()
        {
            if (instance == null)
                instance = this;
        }

        /// <summary>
        /// 配置十隻怪物
        /// </summary>
        /// <returns></returns>
        public Mob[] ProduceNormalMaster()
        {
            Random rand = new Random();
            for (int i = 0; i < mobs.Length; i++)
            {
                mobs[i] = new Mob();
                mobs[i].maxHp = rand.Next(0, 1000);
                mobs[i].exp = rand.Next(0, 300);
                mobs[i].index = i;
                mobs[i].hp = mobs[i].maxHp;
                mobs[i].states = (int)Mob.States.滿血;
            }
            return mobs;
        }
        /// <summary>
        /// 存取死亡的怪獸
        /// </summary>
        /// <param name="mob"></param>
        public void AddDeadMob(Mob mob)
        {
            deadMobs.Add(mob);//增加一隻怪物進來
        }
        /// <summary>
        /// 移除死亡的怪獸
        /// </summary>
        /// <param name="mob"></param>
        public void RemoveDeadMob(Mob mob)
        {
            deadMobs.Remove(mob);
        }
        /// <summary>
        /// 獲得死亡的怪獸
        /// </summary>
        /// <param name="mob"></param>
        public Mob GetDeadMob(int mobIndex)
        {
            //int length = mobs.Count();
            return deadMobs[mobIndex];
        }
        /// <summary>
        /// 找某一隻死亡怪物
        /// </summary>
        public Mob FindDeadMob(int mobKey)
        {
            Dictionary<int, Mob> deadMobID = new Dictionary<int, Mob>();
            if (deadMobID.TryGetValue(mobKey, out mobs[mobKey]) == true)
                return mobs[mobKey];
            return null;
        }

    }
}
