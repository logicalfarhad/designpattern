using System;

namespace AbstracFactory.AbstractFactory
{
    public class Elephant : IAnimal
    {
        public void Breathe()
        {
            Console.WriteLine("I breathe with my lungs. Its easy!");
        }
    }
}
