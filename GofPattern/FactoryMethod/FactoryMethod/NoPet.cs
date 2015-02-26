using System;

namespace FactoryMethod.FactoryMethod
{
    public class NoPet : IPet
    {
        public void Speak()
        {
            Console.WriteLine("There is no pet with the provider name");
        }
    }
}
