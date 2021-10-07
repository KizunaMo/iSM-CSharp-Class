using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //怪物資訊
            int[] mHp = new int [10]; //怪物血量
            int mMaxHp = 1000; //怪物最大血量
            float[] mExp = new float [10]; // 怪物經驗值
            int index = -1;
            int [] mState = new int [10];//怪物狀態(0滿血 / 1失血 / 2死亡)

            //玩家資訊
            int pSt = 300; //力量
            float pExp = 0f; //經驗值
            int[] pBag = new int[10]; //包包
            bool hasBoom = false;
            int boomDamage = 100;

            //遊戲狀態
            bool gameOver = false;
            bool isBattle = false;

            Random random = new Random();//配置怪物
            for (int i = 0; i < mHp.Length; i++)
            {
                mHp[i] = random.Next(100,mMaxHp-1);
                mExp[i] = random.Next(10, 90);
                mState[i] = 0;
            }

            Console.WriteLine(" 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
            while (true)
            {
                string cmd = Console.ReadLine();
                if(!gameOver)
                {
                    switch (cmd)
                    {
                        case "0"://顯示選單
                            Console.WriteLine("再次確認 Y:結束遊戲 / N:繼續遊戲");
                            string check = Console.ReadLine();
                            switch (check.ToLower())
                            {
                                case "y":
                                    Console.WriteLine("結束");
                                    gameOver = true;
                                    break;
                                case "n":
                                    Console.WriteLine("繼續遊戲 請輸入指令 0 / 1 / 2 ");
                                    break;
                            }
                            break;

                        case "1"://顯示玩家資訊
                            Console.WriteLine("玩家力量:" + pSt + "\n玩家經驗值:" + pExp);
                            foreach (int item in pBag)
                            {
                                Console.WriteLine("包包內容" + item);
                            }
                            Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
                            break;

                        case "2": // 進入選怪
                            int newIndex = index;
                            Console.WriteLine("確認是否進入戰鬥 Y/N\n");
                            string checkBattle = Console.ReadLine();
                            switch (checkBattle.ToLower())
                            {
                                case "y":
                                    isBattle = true;
                                    newIndex = random.Next(0, 10);
                                    if (mHp[newIndex] == 0)
                                    {
                                        Console.WriteLine(newIndex + "已死亡\n");
                                        Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("進入戰鬥\n" + "--怪物:" + newIndex + "出現--" + "\n\n怪獸血量" + mHp[newIndex] + "\n怪獸最大血量" + mMaxHp + "\n怪獸經驗值" + mExp[newIndex]);
                                        Console.WriteLine("\n請按下3進行攻擊 / 如果持有炸彈可按4進行炸彈攻擊\n");
                                        if (isBattle)//戰鬥階段
                                        {
                                            int[] getMasterHp = new int[10];
                                            getMasterHp[newIndex] = mHp[newIndex];
                                            while (getMasterHp[newIndex] > 0)
                                            {
                                                string attack = Console.ReadLine();//玩家輸入指令
                                                if (attack == "3")
                                                {
                                                    Console.WriteLine("ATTACK 造成力量值" + pSt + "傷害");
                                                    getMasterHp[newIndex] -= pSt;
                                                    if (getMasterHp[newIndex] <= 0)
                                                    {
                                                        getMasterHp[newIndex] = 0;
                                                        mState[newIndex] = 2;
                                                        Console.WriteLine("怪物血量歸0");
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
                                                        pExp += mExp[newIndex];
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
                                                        Console.WriteLine("玩家獲得經驗值" + mExp[newIndex] + "\n當前戰鬥結束");
                                                        Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
                                                    }
                                                    else
                                                    {
                                                        mState[newIndex] = 1;
                                                        Console.WriteLine("怪物剩餘血量:" + getMasterHp[newIndex] + "\n");
                                                    }
                                                }
                                                else if (attack == "4")
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
                                                            Console.WriteLine("造成炸彈" + boomDamage + "傷害" + "\n怪物血量歸0");
                                                            Console.WriteLine("\n是否放過怪物" + newIndex + "號?" + "要讓怪物復活按5\n");
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
                                                            pExp += mExp[newIndex];
                                                            bool boom = random.Next(0, 2) == 0;
                                                            if (boom == true)
                                                            {
                                                                Console.WriteLine("得到炸彈一顆");
                                                                for (int i = 0; i < pBag.Length; i++)
                                                                {
                                                                    if (pBag[i] == 0)
                                                                    {
                                                                        pBag[i] = 1;
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                            Console.WriteLine("玩家獲得經驗值" + mExp[newIndex] + "當前戰鬥結束");
                                                            Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("造成炸彈" + boomDamage + "傷害" + "\n怪物剩餘血量:" + getMasterHp[newIndex] + "\n");
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("非輸入3或未擁有炸彈時不能攻擊");
                                                }
                                            }
                                        }
                                    }
                                    break;

                                case "n":
                                    isBattle = false;
                                    Console.WriteLine("逃離戰鬥 請輸入指令 0 / 1 / 2 ");
                                    Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
                                    break;
                            }
                            break;

                        case "3":
                            Console.WriteLine("怪物狀態( 0滿血 / 1失血 / 2死亡 )");
                            for (int i = 0; i < mState.Length; i++)
                            {
                                Console.WriteLine("怪獸 " + mState[i]) ;
                            }
                            Console.WriteLine("\n 0:選單(是否繼續遊戲)" + "\n 1:顯示玩家狀態" + "\n 2:進入選怪" + "\n 3:怪物目前狀態\n");
                            break;
                    }
                }
                else
                {
                    switch (cmd.ToUpper())
                    {
                        case "Y":
                        case "N":
                        case "0":
                        case "1":
                        case "2":
                            Console.WriteLine("遊戲已結束   請重新啟動遊戲");
                            break;
                    }
                }
            }
        }
    }
}
