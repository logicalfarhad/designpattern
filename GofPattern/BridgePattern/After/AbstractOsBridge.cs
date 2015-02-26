namespace BridgePattern.After
{
    public abstract class AbstractOsBridge
    {
        protected ISchedulingAlgorithm SchedulingAlgorithm;

        protected AbstractOsBridge(ISchedulingAlgorithm schedulingAlgorithm)
        {
            SchedulingAlgorithm = schedulingAlgorithm;
        }
        public abstract void ExecuteAlgorithm();
    }
}
