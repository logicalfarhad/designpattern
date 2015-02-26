using MediatorPattern.After;
using System;

namespace MediatorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();
            User me = new UserOne("Forhad", chatMediator);
            User person1 = new UserOne("Shuvo", chatMediator);
            User person2 = new UserOne("Sujon", chatMediator);
            User person3 = new UserOne("Moin", chatMediator);
            chatMediator.AddPerson(person1);
            chatMediator.AddPerson(person2);
            chatMediator.AddPerson(person3);

            me.Send("Hi All, How are you?");

            Console.ReadLine();
        }
    }
}
