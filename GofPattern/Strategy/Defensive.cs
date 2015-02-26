using System;

namespace Strategy
{
    public class Defensive : IFighter
    {
        public void Fight()
        {
            Console.WriteLine("Fighter is in Defensice Mood");
        }
    }
}