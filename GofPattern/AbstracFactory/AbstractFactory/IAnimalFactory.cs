namespace AbstracFactory.AbstractFactory
{
    public interface IAnimalFactory
    {
        IAnimal CreateAnimal(AnimalType animalType);
    }
}
