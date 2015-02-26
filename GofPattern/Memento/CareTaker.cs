using System.Collections.Generic;

namespace Memento
{
    public class Caretaker
    {
        private readonly List<Memento> _savedStateList = new List<Memento>();

        public void AddMemento(Memento memento)
        {
            _savedStateList.Add(memento);
        }

        public Memento GetMemento(int index)
        {
            return _savedStateList[index];
        }
    }
}