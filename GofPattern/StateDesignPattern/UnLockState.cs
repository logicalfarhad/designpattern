using System;

namespace StateDesignPattern
{
    public class UnLockState : IGateState
    {
        public Gate Gate { get; set; }
        public UnLockState(Gate gate)
        {
            Gate = gate;
        }
        public void OpenGate()
        {
            Console.WriteLine("The gate is open, can not be unlocked.....");
        }

        public void CloseGate()
        {
            Console.WriteLine("The gate is close, can not be unlocked....");
        }

        public void LockGate()
        {
            Gate.CurrentGateState = Gate.LockedState;
            Console.WriteLine("The gate is unlocked, but it is closed...");
        }

        public void UnLockGate()
        {
            Console.WriteLine("The gate is unlocked already...Can not unlock again");
        }
    }
}
