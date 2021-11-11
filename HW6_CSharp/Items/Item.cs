using System;
using System.Collections.Generic;
using System.Text;
using HW6_CSharp.PlayerRole;

namespace HW6_CSharp.Items
{
    class Item
    {
        string name;
        public virtual string Name { get { return name; } set { name = value; } }
        int[,] itemArray = new int[1, 1];
        public virtual int[,] ItemArray { get { return itemArray; } set { itemArray = value; } }

        int index = 1;
        public virtual int Index { get { return index; } set { index = value; } } 

        public Item()
        {
            name = Name;
            itemArray = ItemArray;
            index = Index;
        }

        public virtual void UseItem(Player player)
        {
        }
    }
}
