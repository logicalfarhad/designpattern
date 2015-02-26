using System;

namespace BridgePattern.After
{
    public class LinuxKernelApi : AbstractOsBridge
    {
        public LinuxKernelApi(ISchedulingAlgorithm schedulingAlgorithm)
            : base(schedulingAlgorithm)
        {
        }
        public override void ExecuteAlgorithm()
        {
            
            SchedulingAlgorithm.ApplyAlgorithm();
            Console.WriteLine("in Linux kernel...");
        }
    }
}