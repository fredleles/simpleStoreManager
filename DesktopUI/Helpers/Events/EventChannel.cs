using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers.Events
{
    internal class EventChannel<TEvent> : IEventChannel<TEvent>
    {
        public EventChannel()
        {
            observers = new List<IHandle<TEvent>>();
        }

        private List<IHandle<TEvent>> observers;

        public IDisposable Subscribe(IHandle<TEvent> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IHandle<TEvent>> _observers;
            private IHandle<TEvent> _observer;

            public Unsubscriber(List<IHandle<TEvent>> observers, IHandle<TEvent> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void PublishEvent(TEvent? _event)
        {
            foreach (var observer in observers)
            {
                if (_event is null)
                    new LocationUnknownException();
                else
                    observer.Listener(_event);
            }
        }
    }
    public class LocationUnknownException : Exception
    {
        internal LocationUnknownException()
        { }
    }
}
