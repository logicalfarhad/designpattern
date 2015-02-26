using System.Collections.Generic;

namespace Observer
{
    interface IObservable
    {
        void Subscribe(ISubscriber subscriber);
        void UnSubscribe(ISubscriber subscriber);
        void NotifySubscribers(List<ISubscriber> subscribers);
    }
}