using System;
using HW6_CSharp.PlayerRole;
using HW6_CSharp.Mobs;

namespace HW6_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //玩家選擇腳色
            //建立怪物種類(史萊姆  哥布林 BOSS龍 等等)
            //建立物件裝備
            //玩家可以裝備物品並使用
            //怪物會掉落物品(可以選擇拿或不拿)，不拿則掉落在地板
            //背包設計 暗黑破壞神的背包 矩陣


            //進入主畫面
            //玩家選擇腳色
            //玩家輸入指令 1. 查看玩家資訊 2. 查看背包資訊(選擇替換裝備) 3. 選擇怪物等級進入戰鬥 
            //顯示戰鬥結果 顯示掉落物品資訊(若死亡回主畫面重頭開始) 若擊敗龍 則成功通關

            
            PlayerCmd playerCmd = new PlayerCmd();
            Information information = new Information();


            //while (true)
            //{
            //    //information.IsBattle();思考怎麼依照當下狀況列印資訊
            //    playerCmd.Round();
            //}

            information.ShowInfo(true, true);

            Console.WriteLine("Hello World!");
        }
    }
}
