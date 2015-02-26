using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempletMethod
{
    public class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water...");
        }

        private void BrewCoffeeGrinds()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into CUP");
        }

        private void AddSugarAndMilk()
        {
            Console.WriteLine("Add Sugar and Milk");
        }
    }
}
