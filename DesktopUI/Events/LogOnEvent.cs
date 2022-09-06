using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesktopUI.Events
{
    internal class LogOnEvent : IEvent
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public LogOnEvent(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
