using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            PlayerCmd cmd = new PlayerCmd();
            UI uI = new UI();
            bool gameOver = false;
            while (!gameOver)
            {
                uI.ShowMenu();
                switch (cmd.Cmd())
                {
                    case "0":
                        Cmd0 cmd0 = new Cmd0();
                        gameOver = cmd0.KeepGameOrNot();
                        break;
                    case "1":
                        Cmd1 cmd1 = new Cmd1();
                        cmd1.PrintPlayerState();
                        break;
                    case "2":
                        Cmd2 cmd2 = new Cmd2();
                        uI.Confirm();
                        if (cmd2.Confirm())
                        {
                            Battle battle = new Battle();
                            battle.StartBattle();
                        }
                        else
                        {
                            uI.ExitBattle();
                        }
                        break;
                    case "3":
                        Cmd3 cmd3 = new Cmd3();
                        cmd3.ListMasterStates();
                        break;
                    default:
                        uI.WrongCmd();
                        break;
                }
            }
        }
    }
}
