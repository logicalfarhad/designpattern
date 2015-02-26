
using System.Collections.Generic;

namespace MediatorPattern.After
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _personList;

        public ChatMediator()
        {
            _personList = new List<User>();
        }
        public void SendMessage(string message, User user)
        {

            foreach (User p in _personList)
            {
                //message should not be received by the user sending it
                if (p != user)
                {
                    p.Receive(message);
                }
            }
        }

        public void AddPerson(User user)
        {
            _personList.Add(user);

        }
    }
}
