using System;

namespace FacadePattern
{
    public class Engine
    {
        public Engine() { }

        public void AddEngine(int cyclinders)
        {
            Console.WriteLine("{0} Cylinder Engine Added", cyclinders.ToString());
        }
    }
}