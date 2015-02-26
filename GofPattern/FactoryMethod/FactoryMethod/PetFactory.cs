namespace FactoryMethod.FactoryMethod
{
    public class PetFactory
    {

        public IPet GetPet(PetType pettype)
        {
            IPet pet = null;
            switch (pettype)
            {
                case PetType.Dog: pet = new Dog();
                    break;
                case PetType.Duck: pet = new Duck();
                    break;
                case PetType.NoPet: pet = new NoPet();
                    break;
            }

            return pet;
        }
    }
}
