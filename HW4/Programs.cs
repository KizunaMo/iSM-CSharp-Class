using System;

namespace HW4
{
    class Programs
    {
        static void Main(string[] args)
        {
            Player.instance= new Player();
            Bag.instance = new Bag();
            SettingMaster settingMaster = new SettingMaster();
            Master[] masters = settingMaster.ProduceNormalMaster();

            PlayerOption playerOption =new PlayerOption();
            playerOption.PlayerCmd(masters);
        }
    }
}
