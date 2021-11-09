using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp
{
    class Bag
    {
        int width = 9;
        int height = 9;
        int[,] bagArray;

        int[,] item = new int[2, 2];


        public Bag(int width, int heigh)
        {
            this.width = width;
            this.height = heigh;

            bagArray = new int[width, heigh];

            item.GetLength(0);
            for (int i = 0; i < item.GetLength(0); i++)
            {
                for (int j = 0; j < item.GetLength(1); j++)
                {
                    item[i, j] = 1;
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
        }

        public void AddItem(int x, int y, int value)
        {
            if (x >= 0 && y >= 0 && x < width && y <= height)
            {
                for (int i = 0; i < bagArray.GetLength(0); i++)
                {
                    bagArray[x, y] = value;
                }

            }
        }

        public bool FindPlace()
        {
            for (int x = 0; x < bagArray.GetLength(0); x++)
            {
                for (int y = 0; y < bagArray.GetLength(1); y++)
                {
                    if (bagArray[x, y] == 0)
                    {
                        if (bagArray.GetLength(0) >= bagArray.GetLength(0) - item.GetLength(0) && bagArray.GetLength(1) >= bagArray.GetLength(1) - item.GetLength(1) && countX >0 && countY >0)
                        {
                            for (int i = x ; i <item.GetLength(0)+x; i++)
                            {
                                bagArray[i, y] = 1;

                                for (int j = y; j < item.GetLength(1)+y; j++)
                                {
                                    bagArray[i, j] = 1;
                                }
                            }
                        }
                        else
                        {
                            return false;
                            Console.WriteLine("沒空間");
                        }

                        return true;
                    }
                    else if (bagArray[x, y] == 1)
                    {
                        break;
                    }
                }
            }
            return false;
        }


    }
}
