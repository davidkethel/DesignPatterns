using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public class EventManager
    {

        private Dictionary<EventType, List<IEventListener>> Listeners = [];

        public void Subscribe(EventType eventType, IEventListener listener)
        {

            if (!Listeners.TryGetValue(eventType, out List<IEventListener> currentListenersForEventType))
            {
                Listeners.Add(eventType, [listener]);
            }
            else
            {
                if (currentListenersForEventType == null)
                {
                    currentListenersForEventType = [listener];
                }
                else
                {
                    currentListenersForEventType.Add(listener);
                }

                Listeners[eventType] = currentListenersForEventType;
            }
        }

        public void Unsubscribe(EventType eventType, IEventListener listener)
        {

            var currentListenersForEventType = Listeners[eventType];
            if (currentListenersForEventType != null)
            {
                currentListenersForEventType.Remove(listener);
                Listeners[eventType] = currentListenersForEventType;
            }
        }

        public void Notify(Event @event)
        {
            var listenersForEventType = Listeners[@event.EventType];
            foreach (var listener in listenersForEventType)
            {
                listener.Update(@event);
            }
        }
    }
}
