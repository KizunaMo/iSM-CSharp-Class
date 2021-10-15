using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class Master
    {
        public int index { set; get; } = -1;
        public int hp { set; get; }
        public int exp { set; get; }
        public int maxHp { set; get; }
        public int states { set; get; }//怪物狀態(0滿血 / 1失血 / 2死亡)
        /// <summary>
        /// 怪獸狀態 對應 states列印中文
        /// </summary>
        public enum MasterStates
        {
            滿血,
            失血,
            死亡,
        }

        public Master(int maxHp,int exp)
        {
            this.maxHp = maxHp;
            this.exp = exp;
        }
    }
}
