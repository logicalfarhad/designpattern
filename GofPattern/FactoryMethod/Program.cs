using FactoryMethod.FactoryMethod;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var petFactory = new PetFactory();
            
            var pet = petFactory.GetPet(PetType.Dog);
         
            pet.Speak();
            
            pet = petFactory.GetPet(PetType.Duck);
            
            pet.Speak();
        }
    }
}
