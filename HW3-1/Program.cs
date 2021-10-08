using System;

namespace HW3_1
{
    class Program
    {
        static void Main(string[] args)
        {
                PlayerCanHitMaster();
        }

        /// <summary>
        /// 玩家攻擊怪物
        /// </summary>
        static void PlayerCanHitMaster()
        {
            int mHp = 30; //怪物血量
            float mExp = 300f; //怪物經驗值
            float pExp = 0f; //玩家初始經驗值

            float canHit = AttackMath();
            if (canHit > 1.5f)
            {
                int mHpAfterHit = mHp;
                float playerDamage = PlayerDamage();
                mHpAfterHit = mHpAfterHit - (int)playerDamage;
                if (mHpAfterHit < 0)
                    mHpAfterHit = 0;
                Console.WriteLine("Hit命中!\n" + "玩家對怪物造成的傷害 " + playerDamage + "\n怪物血量" + mHp + ",命中後血量剩餘" + mHpAfterHit);

                if (mHpAfterHit <= 0)
                {
                    float playerGetExp = pExp;
                    Console.WriteLine("怪物死亡\n" + "玩家經驗值" + pExp + "," + "獲得怪獸經驗值" + mExp + ",最後經驗值 = " + (playerGetExp + mExp));
                }
            }
            else
            {
                int mHpAfterHit = mHp;
                Console.WriteLine("Miss\n" + "怪物血量" + mHpAfterHit);
            }
        }

        /// <summary>
        /// 命中公式:攻方敏捷與防禦方敏捷比例加上命中加乘後大於1.5
        /// </summary>
        /// <param name="pDex">攻方敏捷</param>
        /// <param name="mDex">防禦方敏捷</param>
        /// <param name="pAcc">命中加乘</param>
        /// <returns></returns>
        static float AttackMath()
        {
            int mDex = 10; //怪物敏捷度
            int pDex = 30; //玩家敏捷度
            float pAcc = 0.3f; //玩家命中率加乘

            float playerCanHitMaster = ((float)(pDex / mDex) + pAcc);
            return playerCanHitMaster;
        }

        /// <summary>
        /// 傷害公式：傷害大小為攻擊方力量1.4倍 - 對方防禦力 * 2
        /// </summary>
        /// <param name="pSt">攻擊方力量</param>
        /// <param name="mAc">對方防禦力</param>
        /// <returns></returns>
        static float PlayerDamage()
        {
            int pSt = 30; //玩家力量
            int mAc = 10; //怪物防禦力

            float playerDamage = (pSt * 1.4f - mAc * 2);
            return playerDamage;
        }


    }
}
