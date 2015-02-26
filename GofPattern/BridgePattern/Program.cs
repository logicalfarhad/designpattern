using System;
using BridgePattern.After;

namespace BridgePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AbstractOsBridge abstractOsBridge = null;
            abstractOsBridge = new LinuxKernelApi(new RoundRobinAlgorithm());
            abstractOsBridge.ExecuteAlgorithm();
            abstractOsBridge = new Windows32Api(new ShortestJobFirst());
            abstractOsBridge.ExecuteAlgorithm();
            Console.ReadLine();
        }
    }
}
