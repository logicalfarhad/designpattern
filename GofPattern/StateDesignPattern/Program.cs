using System;

namespace StateDesignPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gate = new Gate();
            gate.CurrentGateState = gate.OpenedState;
            gate.OpenGate();
            gate.CloseGate();
            gate.LockGate();
            gate.UnLockGate();
            Console.ReadLine();
        }
    }
}
