using System;

namespace Observer
{
    public class Moderator : ISubscriber
    {
        public String Name { get; set; }
        public Moderator(String name)
        {
            Name = name;
        }
        public void GetNotification(String postTitle)
        {
            Console.WriteLine("Hello Mr:{0} A new post named {1} has been posted in the blog\nyou need to moderate the comments", Name, postTitle);
        }
    }
}
