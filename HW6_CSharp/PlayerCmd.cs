using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp
{
    class PlayerCmd
    {

        string playerCmd = Console.ReadLine().ToLower();
        Queue<string> cmd = new Queue<string>();
        public void SaveControl()
        {
            cmd.Enqueue(playerCmd);
        }

        public void UseControl()
        {
        }
    }
}
