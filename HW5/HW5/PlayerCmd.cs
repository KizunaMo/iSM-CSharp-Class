using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class PlayerCmd
    {
        /// <summary>
        /// 回傳玩家輸入指令的string
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
