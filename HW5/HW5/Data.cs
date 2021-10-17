using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class Data
    {
        public static Data instance;

        public Player player = new Player();
        public Bag playerBag = new Bag();
        public Mob[] mobs = new Mob[10];
        public Mob[] deadMobs = new Mob[10];
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

        public void DeadMob(Mob mob)
        {
            List<Mob> deadMob = new List<Mob>();
        }

        public void GetDeadMob(Mob mob)
        {

        }


    }
}
