using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel();

            Subscribers jeff = new Subscribers("Beffrey");
            channel.Subscribe(jeff);

            Subscribers viggo = new Subscribers("Biggo");
            channel.Subscribe(viggo);

            channel.Content++;

            Subscribers hugo = new Subscribers("Bugo");
            channel.Subscribe(hugo);

            channel.Content++;

            Console.ReadLine();
        }
    }
}
