using System;

namespace Observer
{
    public interface ISubscriber
    {
        void GetNotification(String postTitle);
        String Name { get; set; }
    }
}
