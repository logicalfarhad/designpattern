using System;

namespace CompositeDesignPattern.After
{
    public class Store : IProfitable
    {
        public int Profit { get; set; }
        public int Id { get; set; }
        public String Name { get; set; }
        public int GetProfit()
        {
            return Profit;
        }
        public void AddChild(IProfitable profitable)
        {
            throw new NotImplementedException();
        }
        public void RemoveChild(IProfitable profitable)
        {
            throw new NotImplementedException();
        }
    }
}
