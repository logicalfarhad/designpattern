using System;
namespace FactoryMethod.FactoryMethod
{
    public class Dog : IPet
    {
        public void Speak()
        {
            Console.WriteLine("Bark bark");
        }
    }
}
