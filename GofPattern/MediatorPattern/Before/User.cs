using System.Collections.Generic;

namespace MediatorPattern.Before
{
    public abstract class User
    {
        protected string Name { get; set; }
        public string Message { get; set; }
        protected readonly List<User> PersonList = new List<User>();
        protected User(string name)
        {
            Name = name;
        }

        public void SendMessage(User user)
        {
            if (user != null)
            {
                PersonList.Add(user);
            }

            UserChecking();
        }
        protected abstract void UserChecking();
    }
}
