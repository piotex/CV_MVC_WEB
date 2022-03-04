using CalendarLibrary.Interfaces;
using CalendarLibrary.Interfaces.Operations;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarLibrary.Code.Operations
{
    public class AddEventToCalendarOperation : IAddEventToCalendarOperation
    {
        private ICalendarClient _calendarClient;
        public AddEventToCalendarOperation(ICalendarClient calendarClient)
        {
            _calendarClient = calendarClient;
        }

        public void AddEventToCalendar(Event _event)
        {
            EventsResource.InsertRequest recurringEvent = _calendarClient.GetCalendarService().Events.Insert(_event, "primary");
            recurringEvent.SendNotifications = true;
            recurringEvent.Execute();
        }
    }
}
