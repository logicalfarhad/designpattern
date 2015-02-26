using System;

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BlogDemo blog = new BlogDemo();

            ISubscriber user = new User("DemoUser");
            ISubscriber moderator = new Moderator("Modu");
            blog.Subscribe(moderator);
            blog.Subscribe(user);
            blog.PostTitle = "Observer Pattern";
            blog.UnSubscribe(moderator);//we unsubscribed the moderator
            blog.PostTitle = "Singleton";
            Console.ReadLine();
        }
    }

}
