using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarLibrary.Interfaces
{
    public interface ICalendarKey
    {
        public string GetClientSecret();
        public string GetClientId();

    }
}
