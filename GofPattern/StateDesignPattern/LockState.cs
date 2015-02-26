using System;

namespace StateDesignPattern
{
    public class LockState : IGateState
    {
        public Gate Gate { get; set; }
        public LockState(Gate gate)
        {
            Gate = gate;
        }
        public void OpenGate()
        {
            Console.WriteLine("Please Close the Gate first and then lock it..");
        }

        public void CloseGate()
        {
            Gate.CurrentGateState = Gate.LockedState;
            Console.WriteLine("The Gate has been locked successfully..");
        }

        public void LockGate()
        {
            Console.WriteLine("The gate is already locked, can not lock again");
        }

        public void UnLockGate()
        {
            Gate.CurrentGateState = Gate.LockedState;
            Console.WriteLine("The gate went to  Locked state from Unlocked state...");
        }
    }
}
