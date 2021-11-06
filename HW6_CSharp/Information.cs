using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp
{
    class Information
    {
        public void IsBattle()//用協程寫寫看?
        {
            bool isBattle = false;
            if (isBattle)
            {
                Console.WriteLine("目標 :打敗怪物龍");
                Console.WriteLine("2//列印玩家資訊");
                Console.WriteLine("3//列印玩家背包資訊");
                Console.WriteLine("4//列印怪物資訊");
                Console.WriteLine("進入戰鬥//進入挑選怪獸");
            }
            else
            {
                Console.WriteLine("武器攻擊");
                Console.WriteLine("道具攻擊");
                Console.WriteLine("逃跑");
                Console.WriteLine("發呆");
                Console.WriteLine("Win");

            }
        }

    }
}
