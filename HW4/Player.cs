using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class Player
    {
        public static Player instance;
        /// <summary>
        /// 玩家的力量傷害
        /// </summary>
        public int power{set;get;} = 300;
        /// <summary>
        /// 玩家經驗值
        /// </summary>
        public float exp { set; get; } = 0f;

        public Player()
        {
            MakeSingleton();
        }
        
        private void MakeSingleton()
        {
            if(instance != null)
            {
                return;
            }
            else
            {
                instance = this;
            }
        }
    }
}
