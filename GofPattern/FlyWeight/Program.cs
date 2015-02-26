using System;
using FlyWeight.FlyWeight;

namespace FlyWeight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ISoldier soldier;
            for (int i = 0; i < 1000; i++)
            {
                soldier = SoldierFactory.GetSoldier(SoldierType.SONNASI);

            }
            Console.WriteLine(Sonnasi.ObjectCounter);
            for (int i = 0; i < 1000; i++)
            {
                soldier = SoldierFactory.GetSoldier(SoldierType.ASUR);
            }
            Console.WriteLine(Asur.Objectcounter);


            Console.ReadLine();
        }
    }
}
