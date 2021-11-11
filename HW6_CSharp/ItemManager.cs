using System;
using System.Collections.Generic;
using System.Text;
using HW6_CSharp.Items;

namespace HW6_CSharp
{
    class ItemManager
    {

        public void ChooseItemToUse(Information information,PlayerCmd playerCmd,PlayerRole.Player player)
        {
            information.ShowInfo(information.UseItems);
            switch (playerCmd.UseControl(2))
            {
                case 1:
                    UseItem(2);
                    break;
                case 2:
                    UseItem(3);
                    break;
            }

            bool UseItem(int itemIndex)
            {
                for (int i = 0; i < player.playerBag.items.Count; i++)
                {
                    if (player.playerBag.items[i].Index == itemIndex)
                    {
                        player.playerBag.items[i].UseItem(player);
                        player.playerBag.Remove(player.playerBag.items[i]);
                        return true;
                    }
                }
                Console.WriteLine($"背包沒有物品");
                return false;
            }
        }
    }
}
