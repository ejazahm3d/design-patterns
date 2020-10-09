using System.Collections.Generic;

namespace Behavioural.Mediator
{
    public abstract class UIControl
    {
        private readonly List<EventHandler> _observers = new List<EventHandler>();

        public void AddEventHandler(EventHandler eventHandler) => _observers.Add(eventHandler);

        protected void NotifyEventHandlers()
        {
            foreach (var observer in _observers)
            {
                observer();
            }
        }
    }
}