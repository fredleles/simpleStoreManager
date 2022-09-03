using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopUI.Helpers.ViewViewModelBind
{
    internal class WindowFactory<T> : IWindowFactory<T>
    {
        private readonly Func<T> _factory;
        public WindowFactory(Func<T> factory)
        {
            _factory = factory;
        }

        public T Show()
        {
            return _factory();
        }
    }
}
