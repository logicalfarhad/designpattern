using System;

namespace Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Caretaker careTaker = new Caretaker();
            Originator originator = new Originator();

            originator.State = "State1";
            careTaker.AddMemento(originator.SaveToMemento());

            originator.State = "State2";
            careTaker.AddMemento(originator.SaveToMemento());

            originator.State = "State3";
            careTaker.AddMemento(originator.SaveToMemento());


            originator.State = "State4";
            careTaker.AddMemento(originator.SaveToMemento());

            originator.RestoreFromMemento(careTaker.GetMemento(2));

            Console.ReadLine();
        }
    }
}
