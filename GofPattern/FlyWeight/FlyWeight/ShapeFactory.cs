using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlyWeight.FlyWeight;

namespace FlyWeight.FlyWeight
{
    public class ShapeFactory
    {

        public static readonly Dictionary<string, IShape> Shapes = new Dictionary<string, IShape>();


        public static IShape GetShape(string type)
        {

            switch (type)
            {
                case "R":
                    if (!Shapes.ContainsKey("R"))

                        Shapes["R"] = new Rectangle("Triangle");
                    return Shapes["R"];
                case "T":

                    if (!Shapes.ContainsKey("T"))
                        Shapes["T"] = new Rectangle("Rectangle");

                    return Shapes["T"];
                default:
                    return null;
            }
            
        }
    }
}
