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
            if (FindSpace(2, 2))
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        bagbox[i, j] += item.itemArea[i, j];
                    }
                }
                for (int j = 0; j < x; j++)
                {
                    for (int i = 0; i < y; i++)
                    {
                        Console.Write(bagbox[i, j]);
                    }
                    Console.Write("\n");
                }
            }
            
        }

        public void UseItem(Items item)
        {
            items.Remove(item);
        }


        public void Print()
        {
            for (int j = 0; j < x; j++)
            {
                for (int i = 0; i < y ; i++)
                {
                    Console.Write(bagbox[i, j]);
                }
                Console.Write("\n");
            }

        }

        public bool FindSpace(int x , int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if(bagbox[i, j] == 0)
                    {
                        return true;
                    }
                    else 
                    {
                        //FindSpace()思考怎麼繼續找下去
                        return false;
                        Console.WriteLine($"沒有空間");
                    }
                }
            }
            return false;
        }


    }
}
