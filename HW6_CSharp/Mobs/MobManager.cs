using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.Mobs
{
    class MobManager
    {
        public List<Mob> mobs = new List<Mob>();

        public MobManager()
        {
            mobs.Add(new Slime());
            mobs.Add(new Goblin());
            mobs.Add(new Dragon());
        }

        public void PrintMobs()
        {
            for (int i = 0; i < mobs.Count; i++)
            {
                Console.WriteLine($"{i+1}");
                mobs[i].PrintStatus();
            }
        }

        public Mob PickOne(int index)
        {
            if (index <= mobs.Count)
            {
                Console.WriteLine($"與怪物{mobs[index-1].Name}戰鬥");
                return mobs[index-1];
            }
            else
                Console.WriteLine("沒有此怪物");
            return null;
        }
    }
}
