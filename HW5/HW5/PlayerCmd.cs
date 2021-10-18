using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class PlayerCmd
    {
        /// <summary>
        /// 執行玩家指令
        /// </summary>
        /// <returns></returns>
        public void MenuCmd()
        {
            bool gameOver = false;
            while (!gameOver)
            {
                UI.instance.ShowMenu();
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        Cmd0 cmd0 = new Cmd0();
                        gameOver = cmd0.KeepGameOrNot();
                        break;
                    case "1":
                        Cmd1 cmd1 = new Cmd1();
                        cmd1.PrintPlayerState();
                        break;
                    case "2":
                        Cmd2 cmd2 = new Cmd2();
                        UI.instance.Confirm();
                        if (cmd2.Confirm())
                        {
                            Battle battle = new Battle();
                            battle.StartBattle();
                        }
                        else
                        {
                            UI.instance.ExitBattle();
                        }
                        break;
                    case "3":
                        Cmd3 cmd3 = new Cmd3();
                        cmd3.ListMasterStates();
                        break;
                    default:
                        UI.instance.WrongCmd();
                        break;
                }
            }
        }
        /// <summary>
        /// 玩家在戰鬥時輸入的指令
        /// </summary>
        /// <returns></returns>
        public string Cmd()
        {
            string cmd = Console.ReadLine();
            return cmd;
        }


        /// <summary>
        /// 回傳是否戰鬥的bool值
        /// </summary>
        /// <returns></returns>
        public bool BattleConfirm()
        {
            string checkBattle = Console.ReadLine();
            switch (checkBattle.ToLower())
            {
                case "y":
                    return true;
                case "n":
                    return false;
            }
            return false;
        }
    }
}
