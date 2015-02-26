using System;

namespace BridgePattern
{
    public class LinuxShortestJobFirst : IShortestJobFirst
    {
        public void ApplyAlgorithm()
        {
            Console.Write("Shortest Job First Thread Scheduling using Linux Kernel API");
        }
    }
}
