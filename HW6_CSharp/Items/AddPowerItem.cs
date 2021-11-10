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
        }

        public void AddPower(Player player)
        {
            int addPower = 30;
            player.PowerDamage += addPower; 
        }
    }
}
