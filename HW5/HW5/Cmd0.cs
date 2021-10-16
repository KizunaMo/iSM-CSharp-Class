using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class Cmd0
    {
        /// <summary>
        /// 確認是否退出遊戲
        /// </summary>
        /// <returns></returns>
        public bool KeepGameOrNot()
        {
            Console.WriteLine("再次確認 Y:結束遊戲 / N:繼續遊戲");
            string check = Console.ReadLine();
            switch (check.ToLower())
            {
                case "y":
                    Console.WriteLine("遊戲已結束   請重新啟動遊戲");
                    return true;
                case "n":
                    Console.WriteLine("繼續遊戲 請輸入指令 0 / 1 / 2 ");
                    return false;
            }
            return false;
        }
    }
}
