using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class UI
    {
        public static UI instance;

        public UI()
        {
            MakeSingleton();
        }

        private void MakeSingleton()
        {
            if (instance == null)
                instance = this;
        }

        /// <summary>
        /// 顯示菜單
        /// </summary>
        public void ShowMenu()
        {
            Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
        }
        /// <summary>
        /// 玩家輸入錯誤指令
        /// </summary>
        public void WrongCmd()
        {
            Console.WriteLine("請依照指示輸入指令");
        }


        /// <summary>
        /// 顯示玩家狀態
        /// </summary>
        public void ListPlayerState(int playerPower, int playerExp, Bag playerBag)
        {
            Console.WriteLine($"玩家力量{playerPower}\n玩家經驗值{playerExp}\n玩家包包\n");
            for (int i = 0; i < playerBag.bag.Length; i++)
            {
                Console.WriteLine(Data.instance.playerBag.bag[i]);
            }
        }
        /// <summary>
        /// 確認是否戰鬥顯示UI
        /// </summary>
        public void Confirm()
        {
            Console.WriteLine("確認是否進入戰鬥 Y/N\n");
        }
        /// <summary>
        /// 逃離戰鬥
        /// </summary>
        public void ExitBattle()
        {
            Console.WriteLine("逃離戰鬥 請輸入指令 0 / 1 / 2 ");
        }
        /// <summary>
        /// 顯示怪物狀態列表
        /// </summary>
        /// <param name="mob"></param>
        public void ListMobStates(Mob[] mob)
        {
            Console.WriteLine("怪物狀態( 0滿血 / 1失血 / 2死亡 )");
            for (int i = 0; i < mob.Length; i++)
            {
                Console.WriteLine($"怪獸編號{Data.instance.mobs[i].index} 怪獸狀態 {(Mob.States)Data.instance.mobs[i].states} 怪獸生命{Data.instance.mobs[i].hp} ");
            }
        }
        /// <summary>
        /// 顯示進入戰鬥後出現的怪物資訊
        /// </summary>
        /// <param name="mobIndex"></param>
        /// <param name="mobHp"></param>
        /// <param name="mobExp"></param>
        public void EnterBattle(int mobIndex, int mobHp , int mobExp)
        {
            Console.WriteLine("進入戰鬥\n" + "--怪物:" + mobIndex + "出現--" + "\n\n怪獸血量" + mobHp + "\n怪獸經驗值" + mobExp);
            Console.WriteLine("\n請按下3進行攻擊 / 如果持有炸彈可按4進行炸彈攻擊\n");
        }

        /// <summary>
        /// 獲得一個炸彈
        /// </summary>
        public void GetItem(int itemIndex)
        {
            Console.WriteLine($"玩家得到一個{(Items.items)itemIndex}");
        }

        /// <summary>
        /// 戰鬥結束
        /// </summary>
        public void EndBattle(int mobExp)
        {
            Console.WriteLine("玩家獲得經驗值 " + mobExp + "\n當前戰鬥結束");
        }
        /// <summary>
        /// 列印沒有該物品可使用
        /// </summary>
        /// <param name="itemIndex"></param>
        public void NoMore(int itemIndex)
        {
            Console.WriteLine($"無{(Items.items)itemIndex}可使用\n");
        }
        /// <summary>
        /// 列印怪物奄奄一息
        /// </summary>
        /// <param name="mobIndex"></param>
        public void AlomstDead(int mobIndex)
        {
            Console.WriteLine("怪物" + mobIndex + "奄奄一息");
        }

        /// <summary>
        /// 列印詢問玩家是否放過怪物
        /// </summary>
        public void LetItGo(int mobIndex)
        {
            Console.WriteLine("\n是否放過怪物" + mobIndex + "號?" + "\n要讓怪物復活按5\n");
        }

        /// <summary>
        /// 列印怪物滿血復活了
        /// </summary>
        /// <param name="mobIndex"></param>
        public void Revival(int mobIndex)
        {
            Console.WriteLine("怪物" + mobIndex + "滿血復活逃走了");
        }
        /// <summary>
        /// 列印怪物死亡了
        /// </summary>
        /// <param name="mobIndex"></param>
        public void DeadMob(int mobIndex)
        {
            Console.WriteLine("怪物" + mobIndex + "死亡");
        }

        /// <summary>
        /// 列印怪獸受到多少傷害，血量降至0
        /// </summary>
        /// <param name="damage"></param>
        public void HurtMob(int damage)
        {
            Console.WriteLine("造成" + damage + "傷害" + "\n怪物血量歸0");
        }
        /// <summary>
        /// 列印怪獸受到多少傷害，血量高於0時使用。
        /// </summary>
        public void A(int damage,Mob mob)
        {
            Console.WriteLine("造成" + damage + "傷害" + "\n怪物剩餘血量:" + mob.hp);
        }
        /// <summary>
        /// 使用道具進行攻擊
        /// </summary>
        public void UseItemAttack(int itemIndex)
        {
            Console.WriteLine($"使用道具{(Items.items)itemIndex}進行攻擊");
        }
    }
}
