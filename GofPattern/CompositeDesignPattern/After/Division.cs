using System;
using System.Collections.Generic;

namespace CompositeDesignPattern.After
{
    public class Division : IProfitable
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<IProfitable> CityList { get; private set; }
        public Division()
        {
            CityList = new List<IProfitable>();
        }
        public int GetProfit()
        {
            int totalProfit = 0;
            foreach (IProfitable city in CityList)
            {
                totalProfit += city.GetProfit();
            }
            return totalProfit;
        }
        public void AddChild(IProfitable profitable)
        {
            if (profitable is City)
                CityList.Add(profitable);
        }
        public void RemoveChild(IProfitable profitable)
        {
            if (profitable is City)
                CityList.Remove(profitable);
        }
    }
}
