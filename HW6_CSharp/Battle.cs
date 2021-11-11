using System;
using System.Collections.Generic;
using System.Text;
using HW6_CSharp.PlayerRole;
using HW6_CSharp.Mobs;
using HW6_CSharp.Items;

namespace HW6_CSharp
{
    class Battle
    {
        MobManager mobManager = new MobManager();
        Mob mob = new Mob();

        public bool BattleTime(Information information, PlayerCmd playerCmd, Player player)
        {
            mobManager.PrintMobs();
            ChooseMobToBattle(playerCmd);
            bool inBattle = true;
            while (inBattle)
            {
                information.ShowInfo(information.BattleMenu);
                int maxCmdNumber;
                switch (playerCmd.UseControl(maxCmdNumber = 4))
                {
                    case 1:
                        Fight(player, mob);
                        if (player.IsDead())
                        {
                            inBattle = false;
                            mobManager = new MobManager();
                            Console.WriteLine("重新開始");
                        }
                        else if (mobManager.mobsAlive[2].Hp <= 0)
                        {
                            inBattle = false;
                            Console.WriteLine($"恭喜完成任務");
                            return true;
                        }
                        else if (mob.isDead())
                        {
                            inBattle = false;
                            mobManager = new MobManager();
                            player.playerBag.FindPlaceAndAddItem(mob.DropItem());
                            Console.WriteLine($"恭喜擊敗{mob.Name}");
                        }
                        else
                            inBattle = true;
                        break;
                    case 2:
                        ItemManager itemManager = new ItemManager();
                        itemManager.ChooseItemToUse(information, playerCmd, player); 
                        break;
                    case 3:
                        inBattle = false;
                        mobManager.PrintMobs();
                        break;
                }
            }
            return false;
        }

        private void ChooseMobToBattle(PlayerCmd playerCmd)
        {
            mob = mobManager.PickOne(playerCmd.UseControl(mobManager.mobsAlive.Count));
        }

        public void Fight(Player player, Mob mob)
        {
            player.Attack(mob, player.PowerDamage);
            player.BeAttack(mob.Attack());
        }

    }
}
