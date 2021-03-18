using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Subscribers : ISubscriber
    {
        public string SubscriberName { get; private set; }

        public Subscribers(string name)
        {
            SubscriberName = name;
        }

        public void Update()
        {
            Console.WriteLine(SubscriberName + ": A new video has been released!");
        }
    }
}
