using System;
using System.Collections.Generic;
using System.Text;
using HW6_CSharp.PlayerRole;

namespace HW6_CSharp.Items
{
    class AddPowerItem: Item
    {
        private string name = "AddPowerItem";
        public override string Name { get => base.Name; set => base.Name = value; }

        private int[,] itemArray = new int[3, 2];
        public override int[,] ItemArray { get => base.ItemArray; set => base.ItemArray = value; }
        int index = 3;
        public override int Index { get => base.Index; set => base.Index = value; }

        public AddPowerItem()
        {
            Name = name;
            ItemArray = itemArray;
            for (int i = 0; i < itemArray.GetLength(0); i++)
            {
                for (int j = 0; j < itemArray.GetLength(1); j++)
                {
                    itemArray[i, j] = 1;
                }
            }
            Index = index;
        }

        public void AddPower(Player player)
        {
            int addPower = 90;
            player.PowerDamage += addPower;
            Console.WriteLine($"玩家增加傷害{addPower},目前傷害{player.PowerDamage}");
        }
        public override void UseItem(Player player)
        {
            AddPower(player);
            base.UseItem(player);
        }
    }
}
