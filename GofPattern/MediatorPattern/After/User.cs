
namespace MediatorPattern.After
{
    public abstract class User
    {

        protected IChatMediator ChatMediator;
        protected string Name { get; set; }

        protected User(string name, IChatMediator chatMediator)
        {
            Name = name;
            ChatMediator = chatMediator;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
