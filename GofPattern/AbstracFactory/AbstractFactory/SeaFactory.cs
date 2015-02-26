namespace AbstracFactory.AbstractFactory
{
    class SeaFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(AnimalType animalType)
        {
            return new Shark();
        }
    }
}
