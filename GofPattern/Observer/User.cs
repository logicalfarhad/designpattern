using System;

namespace Observer
{
    public class User : ISubscriber
    {
        public String Name { get; set; }
        public User(String name)
        {
            Name = name;
        }
        public void GetNotification(String postTitle)
        {
            Console.WriteLine("Hello  Mr: {0} Checkout the new post named {1}", Name, postTitle);
        }
    }
}
