using System;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //怪物資訊
            int[] mHp = new int[10]; //怪物血量
            int mMaxHp = 1000; //怪物最大血量
            float[] mExp = new float[10]; // 怪物經驗值
            int index = -1;
            int[] mState = new int[10];//怪物狀態(0滿血 / 1失血 / 2死亡)

            //玩家資訊
            int pSt = 300; //力量
            float pExp = 0f; //經驗值
            int[] pBag = new int[10]; //包包
            bool hasBoom = false;
            int boomDamage = 100;

            //配置怪物
            Random random = new Random();
            for (int i = 0; i < mHp.Length; i++)
            {
                mHp[i] = random.Next(100, mMaxHp - 1);
                mExp[i] = random.Next(10, 90);
                mState[i] = 0;
            }

            bool gameOver = false;
            while (!gameOver)
            {
                Menu();
                string cmd = PlayerCmd();
                switch (cmd.ToLower())
                {
                    case "0":
                        gameOver = KeepGameOrNot();
                        break;
                    case "1":
                        PlayerStatus(ref pExp,pSt,ref pBag);
                        break;
                    case "2":
                        bool enterBattle = Confirm();
                        if(enterBattle)
                        Battle(index, pSt,ref mState,ref pBag, hasBoom, boomDamage,ref pExp,ref mExp,mHp, mMaxHp);
                        break;
                    case "3":
                        MasterStatus(ref mState);
                        break;
                }
            }
        }
        /// <summary>
        /// 玩家輸入指令
        /// </summary>
        /// <returns></returns>
        static string PlayerCmd()
        {
            string cmd = Console.ReadLine();
            return cmd;
        }
        /// <summary>
        /// 是否進入戰鬥
        /// </summary>
        /// <returns></returns>
        static bool Confirm()
        {
            Console.WriteLine("確認是否進入戰鬥 Y/N\n");
            string checkBattle = Console.ReadLine();
            switch (checkBattle.ToLower())
            {
                case "y":
                    return true;
                case "n":
                    Console.WriteLine("逃離戰鬥 請輸入指令 0 / 1 / 2 ");
                    return false;
            }
            return false;
        }
        /// <summary>
        /// 顯示菜單
        /// </summary>
        static void Menu()
        {
            Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
        }
        /// <summary>
        /// 是否退出遊戲
        /// </summary>
        /// <returns></returns>
        static bool KeepGameOrNot()
        {
            Console.WriteLine("再次確認 Y:結束遊戲 / N:繼續遊戲");
            string check = Console.ReadLine();
            switch (check.ToLower())
            {
                case "y":
                    GameIsOver();
                    return true;
                case "n":
                    Console.WriteLine("繼續遊戲 請輸入指令 0 / 1 / 2 ");
                    return false;
            }
            return false;
        }
        static void GameIsOver()
        {
            Console.WriteLine("遊戲已結束   請重新啟動遊戲");
        }
        /// <summary>
        /// 玩家狀態
        /// </summary>
        /// <param name="pExp">玩家經驗值</param>
        /// <param name="pSt">玩家力量</param>
        /// <param name="pBag">玩家包包</param>
        static void PlayerStatus(ref float pExp,int pSt,ref int[]pBag)
        {

            Console.WriteLine("玩家力量:" + pSt + "\n玩家經驗值:" + pExp);
            foreach (int item in pBag)
            {
                Console.WriteLine("包包內容" + item);
            }
        }
        /// <summary>
        /// 戰鬥階段
        /// </summary>
        /// <param name="index">編號</param>
        /// <param name="pSt">玩家力量</param>
        /// <param name="mState">怪獸狀態</param>
        /// <param name="pBag">玩家包包</param>
        /// <param name="hasBoom">是否擁有炸彈</param>
        /// <param name="boomDamage">炸彈傷害</param>
        /// <param name="pExp">玩家經驗</param>
        /// <param name="mExp">怪物經驗</param>
        /// <param name="mHp">怪物血量</param>
        /// <param name="mMaxHp">怪物最大血量</param>
        static void Battle(int index, int pSt,ref int[] mState,ref int[] pBag, bool hasBoom, int boomDamage,ref float pExp, ref float[] mExp,int[] mHp, int mMaxHp)
        {
            Random random = new Random();
            int newIndex = index;
            newIndex = random.Next(0, 10);
            int[] getMasterHp = new int[10];
            for (int i = 0; i < mHp.Length; i++)
            {
                getMasterHp[i] = mHp[i];
            }
            bool revival = false;
            Console.WriteLine("進入戰鬥\n" + "--怪物:" + newIndex + "出現--" + "\n\n怪獸血量" + mHp[newIndex] + "\n怪獸最大血量" + mMaxHp + "\n怪獸經驗值" + mExp[newIndex]);
            Console.WriteLine("\n請按下3進行攻擊 / 如果持有炸彈可按4進行炸彈攻擊\n");
            while (mState[newIndex] == 0 || mState[newIndex] == 1)
            {
                string cmd = PlayerCmd();
                if (cmd == "3")
                {
                    Console.WriteLine("ATTACK 造成力量值" + pSt + "傷害");
                    getMasterHp[newIndex] -= pSt;
                    if (getMasterHp[newIndex] <= 0)
                    {
                        getMasterHp[newIndex] = 0;
                        mState[newIndex] = 2;
                        Console.WriteLine("怪物血量歸0");
                        revival = true;
                        GetBoom(ref pBag);
                        pExp += mExp[newIndex];
                        Console.WriteLine("玩家獲得經驗值" + mExp[newIndex] + "當前戰鬥結束");
                    }
                    else
                    {
                        mState[newIndex] = 1;
                        Console.WriteLine("怪物剩餘血量:" + getMasterHp[newIndex] + "\n");
                    }
                }
                else if (cmd == "4")
                {
                    int boomID = -1;
                    for (int i = 0; i < pBag.Length; i++)
                    {
                        if (pBag[i] == 1)
                        {
                            boomID = i;
                            pBag[i] = 0;
                            hasBoom = true;
                            Console.WriteLine("炸彈可使用");
                            break;
                        }
                    }
                    if (boomID == -1)
                    {
                        hasBoom = false;
                        Console.WriteLine("無炸彈可使用\n");
                    }
                    if (hasBoom)
                    {
                        getMasterHp[newIndex] -= boomDamage;
                        if (getMasterHp[newIndex] <= 0)
                        {
                            getMasterHp[newIndex] = 0;
                            mState[newIndex] = 2;
                            Console.WriteLine("造成炸彈" + boomDamage + "傷害" + "\n怪物血量歸0");
                            revival = true;
                            GetBoom(ref pBag);
                            pExp += mExp[newIndex];
                            Console.WriteLine("玩家獲得經驗值" + mExp[newIndex] + "當前戰鬥結束");
                        }
                        else
                        {
                            Console.WriteLine("造成炸彈" + boomDamage + "傷害" + "\n怪物剩餘血量:" + getMasterHp[newIndex] + "\n");
                        }
                    }
                }
            }
            if (mState[newIndex] == 2)
            {
                Console.WriteLine("怪物" + newIndex + "死亡");
            }
            if (revival)
                AliveMaster(ref newIndex, ref mState,ref mHp, ref getMasterHp);
        }
        /// <summary>
        /// 顯示怪物狀態
        /// </summary>
        /// <param name="mState"></param>
        static void MasterStatus(ref int[] mState)
        {
            Console.WriteLine("怪物狀態( 0滿血 / 1失血 / 2死亡 )");
            for (int i = 0; i < mState.Length; i++)
            {
                Console.WriteLine("怪獸 " + mState[i]);
            }
        }
        /// <summary>
        /// 是否獲得炸彈
        /// </summary>
        /// <param name="pBag"></param>
        static void GetBoom(ref int[] pBag)
        {
            Random random = new Random();
            bool boom = random.Next(0, 2) == 0;
            if (boom == true)
            {
                Console.WriteLine("玩家得到炸彈一顆");
                for (int i = 0; i < pBag.Length; i++)
                {
                    if (pBag[i] == 0)
                    {
                        pBag[i] = 1;
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// 復活怪物
        /// </summary>
        /// <param name="newIndex">戰鬥階段的編號</param>
        /// <param name="mState"></param>
        /// <param name="mHp"></param>
        /// <param name="getMasterHp">戰鬥階段的怪物血量</param>
        static void AliveMaster(ref int newIndex,ref int[] mState,ref int[] mHp,ref int[] getMasterHp)
        {
            Console.WriteLine("\n是否放過怪物" + newIndex + "號?" + "\n要讓怪物復活按5\n");
            string alive = Console.ReadLine();
            if (alive == "5")
            {
                mState[newIndex] = 0;
                Console.WriteLine("怪物" + newIndex + "滿血復活逃走了");
            }
            else
            {
                mHp[newIndex] = getMasterHp[newIndex];
                mState[newIndex] = 2;
                Console.WriteLine("怪物" + newIndex + "死亡");
            }
        }
        /// <summary>
        /// 確認怪物是否死亡
        /// </summary>
        /// <param name="mHp"></param>
        /// <param name="newIndex"></param>
        /// <returns></returns>
        static bool CheckMasterAlive(int[] mHp, int newIndex)
        {
            bool alive = true;
            if (mHp[newIndex] == 0)
            {
                alive = false;
                Console.WriteLine(newIndex + "已死亡\n");
                Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
            }
            return alive;
        }
    }
}



