using System;

namespace CompositeDesignPattern.After
{
    public interface IProfitable
    {
        int GetProfit();
        void AddChild(IProfitable profitable);
        void RemoveChild(IProfitable profitable);
        int Id { get; set; }
        String Name { get; set; }
    }
}
