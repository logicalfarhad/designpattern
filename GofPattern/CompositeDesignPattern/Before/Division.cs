using System;
using System.Collections.Generic;
namespace CompositeDesignPattern.Before
{
    public class Division
    {
        public List<City> CityList { get; private set; }

        public int Id { get; set; }
        public int Profit { get; set; }
        public String Name { get; set; }
        public Division()
        {
            CityList = new List<City>();
        }

        public void AddCity(City city)
        {
            CityList.Add(city);
        }

        public void RemoveCity(City city)
        {
            CityList.Remove(city);
        }

        public int GetDivisionProfit()
        {
            int totalProfit = 0;
            foreach (City city in CityList)
            {
                foreach (Store store in city.StoreList)
                {
                    totalProfit += store.Profit;
                }
            }
            return totalProfit;
        }
    }
}
