using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class Cmd3
    {
        /// <summary>
        /// 列印怪物狀態列表
        /// </summary>
        public void ListMasterStates()
        {
            UI.instance.ListMobStates(Data.instance.mobs);
        }
    }
}
