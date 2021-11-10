using System;
using HW6_CSharp.PlayerRole;
using HW6_CSharp.Items;
using System.Collections.Generic;
using System.Collections;

namespace HW6_CSharp
{
    class Program
    {


        static void Main(string[] args)
        {
            Bag bag = new Bag(4,4);
            Item item = new HealItem();
            bag.FindPlaceAndAddItem(itemArray, item);
            

            Console.WriteLine($"");
            

            Information information = new Information();
            PlayerCmd playerCmd = new PlayerCmd();
            Player player = new Player(new NoWeapon());
            Battle battle = new Battle();
            bool isChoosed = true;
            while (isChoosed)
            {
                ChooseRole(information, playerCmd, ref player, ref isChoosed);
            }

            while (true)
            {
                information.ShowInfo(information.MainMenu);
                int maxNumber;
                switch (playerCmd.UseControl(maxNumber = 3))
                {
                    case 1:
                        player.PrintStatus();
                        break;
                    case 2:
                        player.playerBag.Print();
                        break;
                    case 3:
                        battle.BattleTime(information, playerCmd, player);
                        if(player.Hp<=0)
                            ChooseRole(information, playerCmd, ref player, ref isChoosed);
                        break;
                }
            }
        }
        /// <summary>
        /// 選職業
        /// </summary>
        /// <param name="information"></param>
        /// <param name="playerCmd"></param>
        /// <param name="player"></param>
        /// <param name="isChoose"></param>
        private static void ChooseRole(Information information, PlayerCmd playerCmd, ref Player player, ref bool isChoose)
        {
            information.ShowInfo(information.ChooseRole);
            int maxNumber;
            switch (playerCmd.UseControl(maxNumber = 4))
            {
                case 1:
                    ChooseSwordsMan(out player, out isChoose);
                    break;
                case 2:
                    ChooseAxwWarriors(out player, out isChoose);
                    break;
                case 3:
                    ChooseArcher(out player, out isChoose);
                    break;
                case 4:
                    Console.WriteLine("赤手");
                    isChoose = false;
                    break;
            }
        }

        private static void ChooseArcher(out Player player, out bool isChoose)
        {
            player = new Archer(new ArcgerAttack());
            Console.WriteLine($"選擇弓箭手");
            isChoose = false;
        }

        private static void ChooseAxwWarriors(out Player player, out bool isChoose)
        {
            player = new AxeWarriors(new AxeAttack());
            Console.WriteLine($"選擇斧頭戰士");
            isChoose = false;
        }

        private static void ChooseSwordsMan(out Player player, out bool isChoose)
        {
            player = new SwordsMan(new SwordsAttck());
            Console.WriteLine($"選擇劍士");
            isChoose = false;
        }

    }
}
