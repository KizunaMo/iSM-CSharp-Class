using System;
using System.Collections.Generic;
using System.Text;

namespace HW6_CSharp.Items
{
    class HealItem : Item
    {
        string name = "HealItem";
        public override string Name { get => base.Name; set => base.Name = value; }
        int[,] itemArray = new int[2, 2];
        public override int[,] ItemArray { get => base.ItemArray; set => base.ItemArray = value; }


        public HealItem()
        {
            
            Name = name;
            ItemArray = itemArray;
            for (int i = 0; i < itemArray.GetLength(0); i++)
            {
                for (int j = 0; j < itemArray.GetLength(1); j++)
                {
                    itemArray[i, j] = 1;
                }
            }
        }


        public int Heal()
        {
            int heal = 30;
            return heal;
        }
    }
}
