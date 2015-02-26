using System;

namespace StateDesignPattern
{
    public class Gate
    {
        public IGateState OpenedState;
        public IGateState ClosedState;
        public IGateState LockedState;
        public IGateState UnlockedState;
        public IGateState CurrentGateState { get; set; }

        public Gate()
        {
            OpenedState = new OpenState(this);
            ClosedState = new CloseState(this);
            LockedState = new LockState(this);
            UnlockedState = new UnLockState(this);
            CurrentGateState = OpenedState;
        }
        public void OpenGate()
        {
            CurrentGateState.OpenGate();
        }

        public void CloseGate()
        {
            CurrentGateState.CloseGate();
        }

        public void LockGate()
        {
            CurrentGateState.LockGate();
        }

        public void UnLockGate()
        {
            CurrentGateState.UnLockGate();
        }
    }
}
