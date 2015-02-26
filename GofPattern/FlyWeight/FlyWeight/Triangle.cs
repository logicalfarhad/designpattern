using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlyWeight.FlyWeight;

namespace FlyWeight.FlyWeight
{
    public class Triangle : IShape
    {
        public static int Objectcounter = 0;
        public string Title { get; set; }
        public void Draw()
        {
            Console.WriteLine(Title + " Drawn");
            
        }

       public Triangle(string title)
        {
            Title = title;
            ++Objectcounter;
        }
    }
}
