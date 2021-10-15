using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class PlayerOption
    {
        /// <summary>
        /// 玩家輸入對應指令
        /// </summary>
        public void PlayerCmd(Master[]masters)
        {
            bool gameOver = false;
            while (!gameOver)
            {
                RolesState rolesState = new RolesState();
                Battle battle = new Battle();
                ShowMenu();
                string cmd = Console.ReadLine();
                switch (cmd.ToLower())
                {
                    case "0": 
                        gameOver = KeepGameOrNot();
                        break;
                    case "1": 
                        rolesState.ListPlayerState();
                        break;
                    case "2": 
                        bool enterBattle = Confirm();
                        if (enterBattle)
                            battle.PlayerVSMaster(masters);
                        break;
                    case "3": 
                        rolesState.ListMasterStates(masters);
                        break;
                }
            }
        }
        /// <summary>
        /// 顯示菜單
        /// </summary>
        public void ShowMenu()
        {
            Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
        }
        /// <summary>
        /// 確認是否退出遊戲
        /// </summary>
        /// <returns></returns>
        public bool KeepGameOrNot()
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
        /// <summary>
        /// 確認是否進入戰鬥
        /// </summary>
        /// <returns></returns>
        public bool Confirm()
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
