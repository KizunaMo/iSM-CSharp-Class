using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class Cmd2
    {

        /// <summary>
        /// 回傳bool確認是否進入戰鬥
        /// </summary>
        public bool Confirm()
        {
            PlayerCmd playerCmd = new PlayerCmd();
            return playerCmd.BattleConfirm();
        }

        /// <summary>
        /// 進入戰鬥
        /// </summary>
        public void EnterBattle()
        {
            Battle battle = new Battle();
            battle.StartBattle();
        }
    }
}
