using System;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fighter = new Fighter();
            var random = new Random();

            fighter.Health = random.Next(1, 100);

            if (fighter.Health <= 50)
            {
                fighter.ChangeMood(new Defensive());
            }
            else if (fighter.Health > 50)
            {
                fighter.ChangeMood(new Aggresive());
            }
            Console.ReadKey();
        }
    }
}
