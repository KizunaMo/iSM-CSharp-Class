using System;
using System.Collections.Generic;
using System.Text;
using HW6_CSharp.Items;

namespace HW6_CSharp
{
    class Bag
    {
        int width = 9;
        int height = 9;
        int[,] bagArray;

        List<Item> items = new List<Item>();

        public Bag(int height, int width)
        {
            this.height = height;
            this.width = width;

            bagArray = new int[height, width];
            
            for (int i = 0; i < bagArray.GetLength(0); i++)
            {
                for (int j = 0; j < bagArray.GetLength(1); j++)
                {
                    bagArray[i, j] = 0;
                }
            }
        }

        public void Print()
        {
            for (int x = 0; x < bagArray.GetLength(0); x++)
            {
                for (int y = 0; y < bagArray.GetLength(1); y++)
                {
                    Console.Write($"{bagArray[x, y]}");
                }
                Console.Write($"\n");
            }
            Console.Write($"背包裡面有:\n");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Name);
            }
        }

        /// <summary>
        /// 找到地方並填進去
        /// </summary>
        /// <param name="itemArray"></param>
        /// <returns></returns>
        public bool FindPlaceAndAddItem(int[,] itemArray,Item item)
        {
            for (int x = 0; x < bagArray.GetLength(0); x++)//x<4
            {
                for (int y = 0; y < bagArray.GetLength(1); y++)//y<3
                {
                    if (bagArray[x, y] == 0)
                    {
                        if (bagArray.GetLength(0) - x >= itemArray.GetLength(0) && bagArray.GetLength(1)-y >= itemArray.GetLength(1) )
                        {
                            for (int i = x; i < x+itemArray.GetLength(0); i++)
                            {
                                bagArray[i, y] = 1;

                                for (int j = y; j < y+itemArray.GetLength(1); j++)
                                {
                                    bagArray[i, j] = 1;
                                }
                            }
                            items.Add(item);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
