using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarLibrary.Interfaces
{
    public interface ICalendarClientSecrets
    {
        public ClientSecrets GetCalendarClientSecrets();
    }
}
