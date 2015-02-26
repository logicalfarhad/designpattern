using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlyWeight.FlyWeight;

namespace FlyWeight.FlyWeight
{
    public class Asur : ISoldier
    {
        public int HealthStatus { get; set; }
        public static int Objectcounter = 0;
        public Asur(int healthstatus)
        {
            HealthStatus = healthstatus;
            ++Objectcounter;
        }
        public void Move(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Asur soldier is moving from ({0},{1}) to ({2},{3})", x1, y1, x2, y2);
        }
    }
}
