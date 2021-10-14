using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    public class PlayerOption
    {
        static PlayerOption playerOption = new PlayerOption();
        /// <summary>
        /// 玩家輸入對應指令
        /// </summary>
        public static void PlayerCmd()
        {
            bool gameOver = false;
            while (!gameOver)
            {
                ShowMenu();
                RolesState state = new RolesState();
                string cmd = Console.ReadLine();
                switch (cmd.ToLower())
                {
                    case "0": //通過再確認機制後結束遊戲
                        gameOver = KeepGameOrNot();
                        break;
                    case "1": //顯示玩家狀態
                        state.ListPlayerState();
                        break;
                    case "2": //進入選怪
                        Confirm();
                        break;
                    case "3": //顯示怪物狀態列
                        state.ListMasterStates();
                        break;
                }
            }
            
        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
        }

        

        static bool KeepGameOrNot()
        {
            Console.WriteLine("再次確認 Y:結束遊戲 / N:繼續遊戲");
            string check = Console.ReadLine();
            switch (check.ToLower())
            {
                case "y":
                    Console.WriteLine("遊戲已結束   請重新啟動遊戲");
                    return true;
                case "n":
                    Console.WriteLine("繼續遊戲 請輸入指令 0 / 1 / 2 ");
                    return false;
            }
            return false;
        }
        public static bool Confirm()
        {
            Console.WriteLine("確認是否進入戰鬥 Y/N\n");
            string checkBattle = Console.ReadLine();
            switch (checkBattle.ToLower())
            {
                case "y":
                    return true;
                case "n":
                    Console.WriteLine("逃離戰鬥 請輸入指令 0 / 1 / 2 ");
                    return false;
            }
            return false;
        }
    }
}
