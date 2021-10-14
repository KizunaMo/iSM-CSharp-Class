using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class SettingMaster
    {
        /// <summary>
        /// 配置十隻怪物
        /// </summary>
        public void ProduceNormalMaster()
        {
            Master mob = new Master();
            Master[] mobs = new Master[10];//挖十個洞
            for (int i = 0; i < mobs.Length; i++)
            {
                mobs[i]= new Master();//覆值給每一個洞
            }
            for (int i = 0; i < mobs.Length; i++)
            {
                Random rand = new Random();
                mobs[i].index = i;
                mobs[i].hp = rand.Next(0, 1000);
                mobs[i].exp = rand.Next(0, 300);
                mobs[i].states = 0;
                Console.WriteLine($"怪獸編號{mobs[i].index} 生命值 {mobs[i].hp}");
            }
        }
    }
}
