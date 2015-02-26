using System;

namespace BridgePattern
{
    public class Win32ShortestJobFirst : IShortestJobFirst
    {
        public void ApplyAlgorithm()
        {
            Console.WriteLine("Shortest Job First Thread Scheduling using windows 32 API");
        }
    }
}
