using System;

namespace Memento
{
    public class Originator
    {
        private string _state;
        public string State
        {
            private get
            {
                return _state;

            }
            set
            {
                _state = value;
                Console.WriteLine("Originator: Setting state to " + _state);
            }
        }
        public Memento SaveToMemento()
        {
            Console.WriteLine("Originator: Saving to Memento.");
            return (new Memento(_state));
        }
        public void RestoreFromMemento(Memento memento)
        {
            State = memento.State;
            Console.WriteLine("Originator: State after restoring from Memento: " + State);

        }
    }
}
