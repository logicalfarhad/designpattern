using System;

namespace MediatorPattern.After
{
    public class UserOne : User
    {
        public UserOne(string name, IChatMediator chatMediator)
            : base(name, chatMediator)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine(Name + " :Sending Message=" + message);
            ChatMediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine(Name + " :Received Message:" + message);
        }
    }
}
