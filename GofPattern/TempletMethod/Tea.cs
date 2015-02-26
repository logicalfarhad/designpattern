using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TempletMethod
{
    public class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }
        private void SteepTeaBag()
        {
            Console.WriteLine("Stepping the tea");
        }
        private void PourInCup()
        {
            Console.WriteLine("Pouring into Cup");
        }
        private void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
