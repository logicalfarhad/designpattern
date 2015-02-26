namespace StateDesignPattern
{
    public interface IGateState
    {
        void OpenGate();
        void CloseGate();
        void LockGate();
        void UnLockGate();
    }
}