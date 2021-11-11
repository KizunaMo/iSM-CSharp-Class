using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.Items
{
    class HealItem : Item
    {
        string name = "HealItem";
        public override string Name { get => base.Name; set => base.Name = value; }
        int[,] itemArray = new int[2, 2];
        public override int[,] ItemArray { get => base.ItemArray; set => base.ItemArray = value; }

        int index = 2;
        public override int Index { get => base.Index; set => base.Index = value; }

        public HealItem()
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


        public void Heal(PlayerRole.Player player)
        {
            int heal = 90;
            player.Hp += heal;
            if (player.Hp >= player.MaxHp)
                player.Hp = player.MaxHp;
            Console.WriteLine($"玩家補血{heal} 血量{player.Hp}");
        }

        public override void UseItem(PlayerRole.Player player)
        {
            Heal(player);
            base.UseItem(player);
        }
    }
}
