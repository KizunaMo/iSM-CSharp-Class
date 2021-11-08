using System;
using HW6_CSharp.PlayerRole;
using HW6_CSharp.Mobs;
using System.Collections.Generic;
using System.Collections;

namespace HW6_CSharp
{
    class Program
    {


        static void Main(string[] args)
        {
            Information information = new Information();
            PlayerCmd playerCmd = new PlayerCmd();
            Player player = new Player(new NoWeapon());
            MobManager mobManager = new MobManager();
            Mob mob = new Mob();
            bool inBattle = false;
            bool isDead = false;
            bool isChoosed = true;
            while (isChoosed)
            {
                ChooseRole(information, playerCmd, ref player, ref isChoosed);
            }

            while (true)
            {

                information.ShowInfo(inBattle, isDead);
                int maxNumber;
                if (!inBattle)
                {
                    switch (playerCmd.UseControl(maxNumber = 4))
                    {
                        case 1:
                            player.PrintStatus();
                            break;
                        case 2:

                            break;
                        case 3:
                            BattleTime(playerCmd, player, mobManager, out mob, out inBattle, out isDead);
                            break;
                        case 4:
                            break;
                    }
                }
                else
                {
                    switch (playerCmd.UseControl(maxNumber = 4))
                    {
                        case 1:
                            player.Attack(mob, player.PowerDamage);
                            player.BeAttack(mob.Attack());
                            if (mob.isDead())
                            {
                                Console.WriteLine($"恭喜擊敗{mob.Name}");
                                inBattle = false;
                            }
                            else if (player.IsDead())
                            {
                                inBattle = false;
                                Console.WriteLine("重新開始");
                                ChooseRole(information, playerCmd, ref player, ref isChoosed);
                            }
                            break;
                        case 2:

                            break;
                        case 3:
                            
                            break;
                        case 4:

                            break;
                    }
                }
                
            }
        }

        private static void ChooseRole(Information information, PlayerCmd playerCmd, ref Player player, ref bool isChoose)
        {
            information.ChooseRole();
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

        private static void BattleTime(PlayerCmd playerCmd, Player player, MobManager mobManager, out Mob mob, out bool inBattle, out bool isDead)
        {
            mobManager.PrintMobs();
            mob = mobManager.PickOne(playerCmd.UseControl(mobManager.mobs.Count));
            Battle battle = new Battle();
            isDead = battle.Fight(player, mob);
            inBattle = true;
        }
    }
}
