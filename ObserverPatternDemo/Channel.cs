using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Channel : IChannel
    {
        private List<Subscribers> subscribers = new List<Subscribers>();
        private int _int;

        public int Content
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }

        public void Subscribe(Subscribers observer)
        {
            subscribers.Add(observer);
        }

        public void Unsubscribe(Subscribers observer)
        {
            subscribers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update();
            }
        }
    }
}
