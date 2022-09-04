using System;

namespace DesktopUI.Helpers.Events
{
    internal interface IEventChannel<TEvent>
    {
        void PublishEvent(TEvent _event);
        IDisposable Subscribe(IHandle<TEvent> observer);
    }
}