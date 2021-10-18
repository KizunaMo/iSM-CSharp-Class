using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            UI uI = new UI();
            PlayerCmd cmd = new PlayerCmd();
            cmd.MenuCmd();
        }
    }
}
