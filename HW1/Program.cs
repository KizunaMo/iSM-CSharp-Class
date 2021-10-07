using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            //怪物資訊
            int mHp = 30; //怪物血量
            int mDex = 10; //怪物敏捷度
            int mAc = 10; //怪物防禦力
            float mExp = 300f; //怪物經驗值

            //玩家資訊
            int pSt = 30; //玩家力量
            int pDex = 30; //玩家敏捷度
            float pAcc = 0.3f; //玩家命中率加乘
            float pExp = 0f; //玩家初始經驗值

            //玩家攻擊怪物時，命中與否
            float playerCanHitMaster = ((float)(pDex / mDex) + pAcc);//命中公式:攻方敏捷與防禦方敏捷比例加上命中加乘後大於1.5
            if (playerCanHitMaster >1.5f)
            {
                int mHpAfterHit = mHp;
                float playerDamage = (pSt * 1.4f - mAc * 2);////傷害大小為攻擊方力量1.4倍 - 對方防禦力 * 2
                mHpAfterHit = mHpAfterHit-(int)playerDamage;
                if (mHpAfterHit < 0)
                    mHpAfterHit = 0;
                Console.WriteLine("Hit命中!\n"+"玩家對怪物造成的傷害 " + playerDamage + "\n怪物血量"+mHp+",命中後血量剩餘" + mHpAfterHit);

                if (mHpAfterHit <= 0)
                {
                    float playerGetExp = pExp; 
                    Console.WriteLine("怪物死亡\n" + "玩家經驗值" + pExp + "," + "獲得怪獸經驗值" + mExp + ",最後經驗值 = " + (playerGetExp + mExp));
                }
            }
            else
            {
                int mHpAfterHit = mHp;
                Console.WriteLine("Miss\n"+ "怪物血量" + mHpAfterHit);
            }
        }
    }
}
