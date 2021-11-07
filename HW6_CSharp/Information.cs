using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp
{
    class Information
    {
        private string mainMenu = "\n Press 1 →目標: 打敗怪物龍\n Press 2 →顯示玩家資訊\n Press 3 →顯示玩家背包資訊\n Press 4 →顯示怪物資訊\n Press 5 → 進入戰鬥(挑選怪獸)";
        private string battleMenu = "\n Press 1 →武器攻擊\n Press 2 →道具攻擊\n Press 3 →逃跑\n Press 4 →發呆\n";
        private string deadMenu = "在戰鬥中死亡";
        bool inBattle = true;
        bool isDead = true;


        public void ShowInfo(bool inBattle,bool isDead)
        {
            this.inBattle = inBattle;
            this.isDead = isDead;
            if(!inBattle)
            {
                Console.WriteLine(mainMenu);
            }
            else if(inBattle && !isDead)
            {
                Console.WriteLine(battleMenu);
            }
            else if(inBattle && isDead)
            {
                Console.WriteLine(deadMenu);
            }
        }

    }
}
