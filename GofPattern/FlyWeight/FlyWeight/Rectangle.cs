using System;
using FlyWeight.FlyWeight;

namespace FlyWeight.FlyWeight
{
    public class Rectangle : IShape
    {
        
        public static int Objectcounter = 0;
        public string Title { get; set; }

        public void Draw()
        {
            Console.WriteLine(Title + " Drawn");
            
        }

        public Rectangle(string title)
        {
            Title = title;
            ++Objectcounter;
        }

    }
}
