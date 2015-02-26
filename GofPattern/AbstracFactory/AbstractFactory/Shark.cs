using System;

namespace AbstracFactory.AbstractFactory
{
    public class Shark : IAnimal
    {
        public void Breathe()
        {
            Console.WriteLine("I breathe in water! He he!");
        }
    }
}
