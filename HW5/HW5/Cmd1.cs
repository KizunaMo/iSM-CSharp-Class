using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class Cmd1
    {

        /// <summary>
        /// 列印玩家資料
        /// </summary>
        public void PrintPlayerState()
        {
            UI.instance.ListPlayerState(Data.instance.player.power,Data.instance.player.exp,Data.instance.playerBag);
        }
    }
}
