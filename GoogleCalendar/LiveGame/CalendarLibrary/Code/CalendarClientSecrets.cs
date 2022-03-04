using CalendarLibrary.Interfaces;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarLibrary.Code
{
    public class CalendarClientSecrets : ICalendarClientSecrets
    {
        private ICalendarKey _calendarKey;
        public CalendarClientSecrets(ICalendarKey calendarKey)
        {
            _calendarKey = calendarKey;
        }

        public ClientSecrets GetCalendarClientSecrets()
        {
            return new ClientSecrets
            {
                ClientId = _calendarKey.GetClientId(),
                ClientSecret = _calendarKey.GetClientSecret(),
            }; 
        }

        
    }
}
