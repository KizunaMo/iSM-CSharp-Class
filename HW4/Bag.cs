using System;
using System.Collections.Generic;
using System.Text;

namespace HW4
{
    class Bag
    {
        public static Bag instance;
        public int[] bag { set; get; } = new int[10];
        private void MakeSingleton()
        {
            if (instance != null)
            {
                return;
            }
            else
            {
                instance = this;
            }
        }

        public Bag()
        {
            MakeSingleton();
            for (int i = 0; i < bag.Length; i++)
            {
                bag[i] = 0;
            }
        }

        public static void GetBoom()
        {
            Random random = new Random();
            bool boom = random.Next(0, 2) == 0;
            if (boom == true)
            {
                Console.WriteLine("玩家得到炸彈一顆");
                for (int i = 0; i < Bag.instance.bag.Length; i++)
                {
                    if (Bag.instance.bag[i] == 0)
                    {
                        Bag.instance.bag[i] = 1;
                        break;
                    }
                }
            }
        }

        public void UseBoom()
        {
            for (int i = 0; i < Bag.instance.bag.Length; i++)
            {
                if (Bag.instance.bag[i] == 1)
                {
                    Bag.instance.bag[i] = 0;
                    break;
                }
            }
        }

        public bool CheckBoom()
        {
            for (int i = 0; i < Bag.instance.bag.Length; i++)
            {
                if (Bag.instance.bag[i] == 1)
                    return true;
            }
            return false;
        }
    }
}
