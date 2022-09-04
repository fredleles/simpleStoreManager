using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers.Events
{
    internal interface IHandle<T>
    {
        void Listener(T message);
    }
}
