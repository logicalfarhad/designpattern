namespace AbstracFactory.AbstractFactory
{
    public class LandFactory:IAnimalFactory
    {
        public IAnimal CreateAnimal(AnimalType animalType)
        {
            return new Elephant();
        }
    }
}
