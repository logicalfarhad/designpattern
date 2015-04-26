using System;
using System.Collections.Generic;

namespace CompositeDesignPattern.After
{
    public class City : IProfitable
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<IProfitable> StoreList { get; private set; }
        public City()
        {
            StoreList = new List<IProfitable>();

        }
        public int GetProfit()
        {
            int totalProfit = 0;

            foreach (IProfitable store in StoreList)
            {
                totalProfit += store.GetProfit();
            }

            return totalProfit;
        }

        public void AddChild(IProfitable profitable)
        {
            if (profitable is Store)
                StoreList.Add(profitable);

        }
        public void RemoveChild(IProfitable profitable)
        {
            if (profitable is Store)
                StoreList.Remove(profitable);
        }
    }
}
