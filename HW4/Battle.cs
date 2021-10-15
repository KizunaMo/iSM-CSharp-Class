using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class Battle
    {
        /// <summary>
        /// 玩家對戰怪獸
        /// </summary>
        /// <param name="master"></param>
        public void PlayerVSMaster(Master[] master)
        {
            Random random = new Random();
            int temporaryIndex = random.Next(10);//抽怪獸
            master[temporaryIndex].index = temporaryIndex;

            Console.WriteLine("進入戰鬥\n" + "--怪物:" + temporaryIndex + "出現--" + "\n\n怪獸血量" + master[temporaryIndex].hp + "\n怪獸最大血量" + master[temporaryIndex].maxHp + "\n怪獸經驗值" + master[temporaryIndex].exp);
            Console.WriteLine("\n請按下3進行攻擊 / 如果持有炸彈可按4進行炸彈攻擊\n");

            bool revival = false;
            SettingMaster settingMaster = new SettingMaster();
            while (master[temporaryIndex].states == 0 || master[temporaryIndex].states == 1)
            {
                string cmd = PlayerCmd();
                if (cmd == "3")
                {
                    revival = settingMaster.Injured(Player.instance.power,master[temporaryIndex]);
                    if (revival)
                    {
                        Bag.GetBoom();
                        Player.instance.exp += master[temporaryIndex].exp;
                        Console.WriteLine("玩家獲得經驗值 " + master[temporaryIndex].exp + "\n當前戰鬥結束");
                    }
                }
                else if (cmd == "4")
                {
                    bool hasBoom = Bag.instance.CheckBoom();
                    if (!hasBoom)
                    {
                        Console.WriteLine("無炸彈可使用\n");
                    }
                    if (hasBoom)
                    {
                        Items items = new Items();
                        if (revival)
                        {
                            Bag.GetBoom();
                            Player.instance.exp += master[temporaryIndex].exp;
                            Console.WriteLine("玩家獲得經驗值 " + master[temporaryIndex].exp + "\n當前戰鬥結束");
                        }
                    }
                }
            }
            if (master[temporaryIndex].states == 2)
            {
                Console.WriteLine("怪物" + temporaryIndex + "奄奄一息");
            }
            if (revival)
                settingMaster.Revival(master[temporaryIndex]);
        }
        /// <summary>
        /// 玩家輸入指令
        /// </summary>
        /// <returns></returns>
        public string PlayerCmd()
        {
            string cmd = Console.ReadLine();
            return cmd;
        }
    }
}
