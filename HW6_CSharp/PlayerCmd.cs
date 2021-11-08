using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp
{
    class PlayerCmd
    {
        Queue<int> cmd = new Queue<int>();
        private int maxNumber = 3;
        public int Number { get { return maxNumber; } set { maxNumber = value; } }

        public int UseControl(int maxNumber)
        {
            this.maxNumber = maxNumber;
            SaveControl(maxNumber);
            return cmd.Dequeue();
        }

        private void SaveControl(int maxNumber)
        {
            string playerCmd = Console.ReadLine();
            int n;
            int.TryParse(playerCmd, out n);
            if (n <= 0 || n > maxNumber)
                Console.WriteLine($"輸入錯誤指令，請輸入1~{maxNumber}數字鍵");
            cmd.Enqueue(n);
        }
    }
}
