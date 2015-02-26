using System;

namespace FlyWeight.FlyWeight
{
    public interface ISoldier
    {
        int HealthStatus { get; set; }//intrinsic property
        void Move(int x1, int y1, int x2, int y2);//extansic properties are coordinate
    }
}
