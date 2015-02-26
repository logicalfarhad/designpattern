using System;

namespace BridgePattern.After
{
    public class ShortestJobFirst : ISchedulingAlgorithm
    {
        public void ApplyAlgorithm()
        {
            Console.WriteLine("Shortest Job First Algorithm implemented here ");
        }
    }

    public class A : ISchedulingAlgorithm
    {
        public void ApplyAlgorithm()
        {
            
        }
    }
}
