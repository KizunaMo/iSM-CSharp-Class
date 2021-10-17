using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class Battle
    {
        /// <summary>
        /// 開始戰鬥
        /// </summary>
        public void StartBattle()
        {
            Random random = new Random();
            int temporaryIndex = Data.instance.mobs[random.Next(10)].index;//抽一隻怪獸出來
            UI.instance.EnterBattle(Data.instance.mobs[temporaryIndex].index, Data.instance.mobs[temporaryIndex].hp, Data.instance.mobs[temporaryIndex].exp);
            bool revival = false;
            while (Data.instance.mobs[temporaryIndex].states == 0 || Data.instance.mobs[temporaryIndex].states == 1)
            {
                PlayerCmd playerCmd = new PlayerCmd();
                switch (playerCmd.Cmd())
                {
                    case "3":
                        revival = Data.instance.mobs[temporaryIndex].Injured(Player.instance.power, Data.instance.mobs[temporaryIndex]);
                        if (revival)
                        {
                            Data.instance.player.GetItem(1);
                            Data.instance.player.GetExp(Data.instance.mobs[temporaryIndex]);
                            UI.instance.EndBattle(Data.instance.mobs[temporaryIndex].index);
                        }
                        break;

                    case "4":
                        Bag bag = new Bag();
                        if (!bag.CheckItem(1))
                        {
                            UI.instance.NoMore(1);
                        }
                        else
                        {
                            if (revival)
                            {
                                Data.instance.player.GetItem(1);
                                Data.instance.player.GetExp(Data.instance.mobs[temporaryIndex]);
                                UI.instance.EndBattle(Data.instance.mobs[temporaryIndex].index);
                            }
                        }
                        break;

                    default:
                        UI.instance.WrongCmd();
                        break;
                }
            }
            if (Data.instance.mobs[temporaryIndex].states == 2)
            {
                UI.instance.AlomstDead(Data.instance.mobs[temporaryIndex].index);
            }
            if (revival)
            {
                UI.instance.LetItGo(Data.instance.mobs[temporaryIndex].index);
                PlayerCmd playerCmd = new PlayerCmd();
                switch (playerCmd.Cmd())
                {
                    case "5":
                        Player.instance.Revival(Data.instance.mobs[temporaryIndex]);
                        UI.instance.Revival(Data.instance.mobs[temporaryIndex].index);
                        break;
                    default:
                        UI.instance.DeadMob(Data.instance.mobs[temporaryIndex].index);
                        break;
                }
            }
                
        }
    }
}
