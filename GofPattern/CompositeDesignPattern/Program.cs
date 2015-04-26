using System;
using CompositeDesignPattern.After;
using City = CompositeDesignPattern.After.City;
using Division = CompositeDesignPattern.After.Division;
using Store = CompositeDesignPattern.After.Store;

namespace CompositeDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IProfitable store1 = new Store
            {
                Id = 1,
                Name = "Malibagh BFC",
                Profit = 2
            };
            IProfitable store2 = new Store
            {
                Id = 2,
                Name = "Gulshan BFC",
                Profit = 5
            };

            IProfitable city = new City
            {
                Id = 10,
                Name = "Dhaka"
            };
            city.AddChild(store1);
            city.AddChild(store2);

            IProfitable division = new Division
            {
                Id = 1,
                Name = "Rajshahi"
            };
            division.AddChild(city);
            int totalProfit = division.GetProfit();
            Console.WriteLine("Total Profit of {0} division is : {1}", division.Name, totalProfit);
            Console.ReadLine();
        }
    }
}
