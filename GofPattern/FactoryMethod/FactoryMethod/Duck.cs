using System;

namespace FactoryMethod.FactoryMethod
{
    public class Duck : IPet
    {
        public void Speak()
        {
            Console.WriteLine("Quack quack...");
        }
    }
}
