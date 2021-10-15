using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class SettingMaster
    {
        public Master[] mobs = new Master[10];//挖十個洞
        
        /// <summary>
        /// 配置十隻怪物
        /// </summary>
        public Master[] ProduceNormalMaster()
        {
            Random rand = new Random();
            for (int i = 0; i < mobs.Length; i++)
            {
                int ranMaxHp = rand.Next(0, 1000);
                int ranExp = rand.Next(0, 300);
                mobs[i]= new Master(ranMaxHp,ranExp);//覆值給每一個洞
                mobs[i].maxHp = rand.Next(0, 1000);
                mobs[i].exp = rand.Next(0, 300);
                mobs[i].index = i;
                mobs[i].hp = mobs[i].maxHp;
                mobs[i].states = (int)Master.MasterStates.滿血;
            }
            return mobs;
        }
        /// <summary>
        /// 造成怪獸傷害
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="mobs"></param>
        public bool Injured(int damage,Master mobs)
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
        /// <summary>
        /// 決定是否復活怪獸
        /// </summary>
        /// <param name="mobs"></param>
        public void Revival(Master mobs)
        {
            Console.WriteLine("\n是否放過怪物" + mobs.index + "號?" + "\n要讓怪物復活按5\n");
            string alive = Console.ReadLine();
            if (alive == "5")
            {
                mobs.states = 0;
                mobs.hp = mobs.maxHp;
                Console.WriteLine("怪物" + mobs.index + "滿血復活逃走了");
            }
            else
            {
                mobs.states = 2;
                Console.WriteLine("怪物" + mobs.index + "死亡");
            }
        }
    }
}
