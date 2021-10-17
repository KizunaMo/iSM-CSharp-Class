using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    class Bag
    {
        public int[] bag { set; get; } = new int[10];



        public void SaveItem(int item)
        {

        }

        public void LoseItem(int item)
        {

        }
        /// <summary>
        /// 確認背包有沒有這項物品
        /// </summary>
        /// <param name="itemIndex"></param>
        /// <returns></returns>
        public bool CheckItem(int itemIndex)
        {
            for (int i = 0; i < Data.instance.playerBag.bag.Length; i++)
            {
                if (Data.instance.playerBag.bag[i] == itemIndex)
                    return true;
            }
            return false;
        }
    }
}
