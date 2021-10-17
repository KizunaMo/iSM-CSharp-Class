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
            while (Data.instance.mobs[temporaryIndex].states == (int)Mob.States.滿血 || Data.instance.mobs[temporaryIndex].states == (int)Mob.States.失血)
            {
                PlayerCmd playerCmd = new PlayerCmd();
                switch (playerCmd.Cmd())
                {
                    case "3":
                        revival = Data.instance.mobs[temporaryIndex].Injured(Player.instance.power, Data.instance.mobs[temporaryIndex]);
                        if (revival)
                        {
                            if (Data.instance.player.GetItem((int)Items.items.炸彈))
                                UI.instance.GetItem((int)Items.items.炸彈);
                            Data.instance.player.GetExp(Data.instance.mobs[temporaryIndex]);
                            UI.instance.EndBattle(Data.instance.mobs[temporaryIndex].exp);
                        }
                        break;

                    case "4":
                        if (!Data.instance.playerBag.CheckItem((int)Items.items.炸彈))
                        {
                            UI.instance.NoMore((int)Items.items.炸彈);
                        }
                        else
                        {
                            UI.instance.UseItemAttack((int)Items.items.炸彈);
                            revival = Data.instance.mobs[temporaryIndex].Injured(Data.instance.items.bombDamage, Data.instance.mobs[temporaryIndex]);
                            Data.instance.player.UseItem((int)Items.items.炸彈);
                            if (revival)
                            {
                                if (Data.instance.player.GetItem((int)Items.items.炸彈))
                                    UI.instance.GetItem((int)Items.items.炸彈);
                                Data.instance.player.GetExp(Data.instance.mobs[temporaryIndex]);
                                UI.instance.EndBattle(Data.instance.mobs[temporaryIndex].exp);
                            }
                        }
                        break;

                    default:
                        UI.instance.WrongCmd();
                        break;
                }
            }
            if (Data.instance.mobs[temporaryIndex].states == (int)Mob.States.死亡)
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
