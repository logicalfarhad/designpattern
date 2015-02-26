using System;

namespace Strategy
{
    public class Aggresive : IFighter
    {
        public void Fight()
        {
            Console.WriteLine("Fighter is in Aggresive Mood");
        }
    }
}