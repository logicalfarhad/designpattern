using System;

namespace BridgePattern.After
{
    public class Windows32Api : AbstractOsBridge
    {
        public Windows32Api(ISchedulingAlgorithm schedulingAlgorithm)
            : base(schedulingAlgorithm)
        {
        }

        public override void ExecuteAlgorithm()
        {
            SchedulingAlgorithm.ApplyAlgorithm();
            Console.WriteLine("in Windows 32 Api...");
        }
    }
}