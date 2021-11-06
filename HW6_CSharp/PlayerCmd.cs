using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp
{
    class PlayerCmd
    {
        Queue<int> cmd = new Queue<int>();

        public void Round()
        {
            SaveControl();
            cmd.Dequeue();
        }

        private void SaveControl()
        {
            string playerCmd = Console.ReadLine();
            int n;
            int.TryParse(playerCmd, out n);
            if (n <= 0 || n>5)
                Console.WriteLine("輸入錯誤指令，請輸入1~5數字鍵");
            cmd.Enqueue(n);
        }
    }
}
