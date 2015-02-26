using System;

namespace FlyWeight.FlyWeight
{
    public interface IShape
    {
        String Title { get; set; }
        void Draw();
    }
}
