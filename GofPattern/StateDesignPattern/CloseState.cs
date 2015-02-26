using System;

namespace StateDesignPattern
{
    public class CloseState : IGateState
    {
        public Gate Gate { get; set; }
        public CloseState(Gate gate)
        {
            Gate = gate;
        }
        public void OpenGate()
        {
            Gate.CurrentGateState = Gate.ClosedState;
            Console.WriteLine("The gate has been closed successfully........");
        }

        public void CloseGate()
        {
            Console.WriteLine("The gate is already closed.You can not close it again!!");
        }

        public void LockGate()
        {
            Console.WriteLine("The gate is locked. So you can not close this gate!!");
        }

        public void UnLockGate()
        {
            Console.WriteLine("The gate is unlocked, so it is already closed!!!!");
        }
    }
}
