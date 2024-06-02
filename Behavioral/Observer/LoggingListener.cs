using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class LoggingListener : IEventListener
    {
        public void Update(Event @event)
        {
            Console.WriteLine($"Logging Listener Update: Event Type: {@event.EventType}, file: {@event.Data}");
        }
    }
}
