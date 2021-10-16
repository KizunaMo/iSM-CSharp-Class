using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary
{
    class Formula
    {
     /// <summary>
     /// 是否獲得炸彈
     /// </summary>
     /// <param name="playerBag"></param>
        static void GetBoom(ref int[] playerBag)
        {
            bool boom = GameLibrary.MyRandom.Next(0, 2) == 0;
            if (boom == true)
            {
                for (int i = 0; i < playerBag.Length; i++)
                {
                    if (playerBag[i] == 0)
                    {
                        playerBag[i] = 1;
                        break;
                    }
                }
                Console.WriteLine("玩家得到炸彈一顆");
            }
        }
    }
}
