using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarLibrary.Interfaces.Operations
{
    public interface IAddEventToCalendarOperation
    {
        public void AddEventToCalendar(Event _event);
    }
}
