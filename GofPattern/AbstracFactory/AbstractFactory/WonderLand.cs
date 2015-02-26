namespace AbstracFactory.AbstractFactory
{
    public class WonderLand : IAnimalFactory
    {
        public IAnimal CreateAnimal(AnimalType animalType)
        {
            IAnimal animal = null;
            switch (animalType)
            {
                case AnimalType.Shark:
                    animal = new Shark();
                    break;
                case AnimalType.Elephant:
                    animal = new Elephant();
                    break;
            }
            return animal;
        }
    }
}
