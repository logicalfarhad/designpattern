using System;
using FlyWeight.FlyWeight;

namespace FlyWeight.FlyWeight
{
    public class Sonnasi : ISoldier
    {
        public int HealthStatus { get; set; }

        public static int ObjectCounter = 0;
        public Sonnasi(int healthStatus)
        {
            HealthStatus = healthStatus;

            ObjectCounter++;
        }
        public void Move(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Sonnasi soldier is moving from ({0},{1}) to ({2},{3})", x1, y1, x2, y2);
        }
    }
}
