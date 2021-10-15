using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class RolesState
    {
        /// <summary>
        /// 顯示玩家狀態
        /// </summary>
        public void ListPlayerState()
        {
            Console.WriteLine("玩家力量:" + Player.instance.power + "\n玩家經驗值:" + Player.instance.exp);
            foreach (int item in Bag.instance.bag)
            {
                Console.WriteLine("包包內容" + item);
            }
        }

        /// <summary>
        /// 顯示怪物狀態列
        /// </summary>
        public void ListMasterStates(Master[] mobs)
        {
            Console.WriteLine("怪物狀態( 0滿血 / 1失血 / 2死亡 )");
            for (int i = 0; i <mobs.Length; i++)
            {
                Console.WriteLine($"怪獸編號{mobs[i].index} 怪獸狀態 {(Master.MasterStates)mobs[i].states} 怪獸生命{mobs[i].hp} ");
            }
        }
    }
}
