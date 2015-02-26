using System;

namespace BridgePattern
{
    public class LinuxRoundRobin : IRoundRobin
    {
        public void ApplyAlgorithm()
        {
            Console.WriteLine("Round Robin Thread Scheduling using Linux Kernel API");
        }
    }
}
