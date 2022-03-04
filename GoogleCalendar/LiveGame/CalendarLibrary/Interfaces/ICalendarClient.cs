using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarLibrary.Interfaces
{
    public interface ICalendarClient
    {
        public CalendarService GetCalendarService();
        public UserCredential GetUserCredential();

    }
}
