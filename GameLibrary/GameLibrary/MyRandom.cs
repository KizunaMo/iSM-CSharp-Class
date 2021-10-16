using System;

namespace GameLibrary
{
    public class MyRandom
    {
        static Random random = new Random();

        public static int Next()
        {
            return random.Next();
        }

        public static int Next(int min,int max)
        {
            return random.Next();
        }
    }
}
