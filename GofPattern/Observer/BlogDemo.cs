using System;
using System.Collections.Generic;

namespace Observer
{
    public class BlogDemo : IObservable
    {
        private String _postTitle;
        private readonly List<ISubscriber> _subscribers;
        public BlogDemo()
        {
            _subscribers = new List<ISubscriber>();
        }
        public String PostTitle
        {
            get
            {
                return _postTitle;
            }
            set
            {
                if (_postTitle != value)
                {
                    _postTitle = value;
                    NotifySubscribers(_subscribers);
                }
            }
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void NotifySubscribers(List<ISubscriber> subscribers)
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.GetNotification(_postTitle);
            }
        }

    }
}
