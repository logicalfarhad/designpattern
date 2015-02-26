using System;

namespace StateDesignPattern
{
    public class OpenState : IGateState
    {
        public Gate Gate { get; set; }
        public OpenState(Gate gate)
        {
            Gate = gate;
        }
        public void OpenGate()
        {
            Console.WriteLine("The gate is already open....");
        }

        public void CloseGate()
        {
            Gate.CurrentGateState = Gate.OpenedState;
            Console.WriteLine("The gate state is now opened from closed state");
        }

        public void LockGate()
        {
            Console.WriteLine("Please unlock the gate and open it....");
        }

        public void UnLockGate()
        {
            Gate.CurrentGateState = Gate.OpenedState;
            Console.WriteLine("The gate is now unlocked and opened ");
        }
    }
}
