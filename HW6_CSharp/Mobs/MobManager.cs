using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.Mobs
{
    class MobManager
    {
        public List<Mob> mobsAlive = new List<Mob>();
        public List<Mob> mobsDead = new List<Mob>();

        public MobManager()
        {
            mobsAlive.Add(new Slime());
            mobsAlive.Add(new Goblin());
            mobsAlive.Add(new Dragon());
        }

        public void PrintMobs()
        {
            for (int i = 0; i < mobsAlive.Count; i++)
            {
                Console.Write($"第{i+1}種");
                mobsAlive[i].PrintStatus();
            }
        }

        public Mob PickOne(int index)
        {
            if (index <= mobsAlive.Count)
            {
                Console.WriteLine($"與怪物{mobsAlive[index-1].Name}戰鬥");
                return mobsAlive[index-1];
            }
            else
                Console.WriteLine("沒有此怪物");
            return null;
        }

        private void SaveMob()
        {
            for (int i = 0; i < mobsAlive.Count; i++)
            {
                if (mobsAlive[i].Hp <= 0)
                {
                    mobsDead.Add(mobsAlive[i]);
                }
            }
        } 
    }
}
