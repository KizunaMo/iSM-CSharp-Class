using System;
using System.Collections.Generic;
using System.Text;
using HW6_CSharp.PlayerRole;

namespace HW6_CSharp
{
    class Items
    {
        string name;
        public string Name { get { return name; } set { name = value; } }
        public int[,] itemArea;
        public Items()
        {

        }
        public Items(ItemsID itemsID)
        {
            this.name = itemsID.ToString();
            int x = 1;
            int y = 1;
            itemArea = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    itemArea[i, j] = 1;
                }
            }
        }

        public enum ItemsID
        {
            nothing,
            healItem,
            bomb,
            addPower,
            count,
        }

        public static Items Product(ItemsID itemsID)
        {
            Items product = new Items(itemsID);
            return product;
        }

        public static Items RandomProduct()
        {
            Random random = new Random();
            int itemsCount = (int)ItemsID.count - 1;
            return Items.Product((Items.ItemsID)random.Next(1, itemsCount));
        }

        public static int Heal()
        {
            int heal = 30;
            return heal;
        }

        public void BombAttack()
        {

        }

        public void AddPower(Player player)
        {
            int addPower = 30;
            player.PowerDamage += addPower;
        }

    }
}
