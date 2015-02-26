using System;

namespace FacadePattern
{
    public class Body
    {
        public Body() { }

        public void AddBody(BodyType bodyType)
        {
            Console.WriteLine("{0} Body Added", Enum.GetName(typeof(BodyType), bodyType));
        }
    }
}