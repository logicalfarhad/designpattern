using System;

namespace BridgePattern
{
    public class Win32RoundRobin : IRoundRobin
    {
        public void ApplyAlgorithm()
        {
            Console.WriteLine("Round Robin Thread Scheduling using windows 32 API");
        }
    }
}
