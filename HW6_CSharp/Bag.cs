using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp
{
    class Bag
    {
        public int[,] bagbox;
        int x = 9;
        int y = 9;
        List<Items> items = new List<Items>();
        Items item = new Items(Items.ItemsID.healItem);

        public Bag()
        {
            bagbox = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    bagbox[i, j] = 0;
                }
            }
        }

        public void AddItem(Items item)
        {
            items.Add(item);
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    bagbox[i, j] += item.itemArea[i, j];
                }
            }
        }

        public void UseItem(Items item)
        {
            items.Remove(item);
        }


        public void Print()
        {
            for (int j = -1; j < x-1; j++)
            {
                for (int i = -1; i < y-1 ; i++)
                {
                    Console.Write(bagbox[i+1, j+1]);
                }
                Console.Write("\n");
            }

        }


    }
}
