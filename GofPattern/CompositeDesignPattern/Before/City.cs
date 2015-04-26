using System;
using System.Collections.Generic;
namespace CompositeDesignPattern.Before
{
    public class City
    {
        public List<Store> StoreList { get; private set; }
        public int Id { get; set; }
        public String Name { get; set; }

        public City()
        {
            StoreList = new List<Store>();
        }

        public void RemoveStore(Store store)
        {
            StoreList.Remove(store);
        }

        public void AddStore(Store store)
        {
            StoreList.Add(store);
        }

        public int GetCityProfit()
        {
            int totalProfit = 0;
            foreach (Store store in StoreList)
            {
                totalProfit += store.Profit;
            }
            return totalProfit;
        }
    }
}
