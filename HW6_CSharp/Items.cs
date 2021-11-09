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
        Items item;
        
        public Items()
        {

        }
        public Items(ItemsID itemsID)
        {
            this.name = itemsID.ToString();
            int x = 2;
            int y = 2;
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

        public Items Product(ItemsID itemsID)
        {
            Items product = new Items(itemsID);
            int x = 2;
            int y = 2;
            itemArea = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    itemArea[i, j] = 1;
                }
            }
            for (int j = 0; j < x; j++)
            {
                for (int i = 0; i < y; i++)
                {
                    Console.Write(itemArea[i, j]);
                }
                Console.Write("\n");
            }
            return product;
        }

        public Items RandomProduct()
        {
            Random random = new Random();
            int itemsCount = (int)ItemsID.count - 1;
            return item.Product((Items.ItemsID)random.Next(1, itemsCount));
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
