using System;

namespace DesignPatterns.Behavioral.Observer
{
    public class EmailListener : IEventListener
    {
        public void Update(Event @event)
        {
            Console.WriteLine($"Email Listener Update: Event Type: {@event.EventType}, file: {@event.Data}");
        }
    }
}
