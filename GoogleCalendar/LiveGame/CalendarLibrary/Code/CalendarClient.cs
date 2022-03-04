using CalendarLibrary.Interfaces;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CalendarLibrary.Code
{
    public class CalendarClient : ICalendarClient
    {
        ICalendarClientSecrets _calendarClientSecrets;
        public CalendarClient(ICalendarClientSecrets calendarClientSecrets)
        {
            _calendarClientSecrets = calendarClientSecrets;
        }

        public UserCredential GetUserCredential()
        {
            string[] scopes = new[] { CalendarService.Scope.Calendar };
            string user = "user";

            return GoogleWebAuthorizationBroker.AuthorizeAsync(_calendarClientSecrets.GetCalendarClientSecrets(), scopes, user, CancellationToken.None).Result;
        }

        public CalendarService GetCalendarService()
        {
            UserCredential userCredential = GetUserCredential();

            BaseClientService.Initializer initializer = new BaseClientService.Initializer
            {
                HttpClientInitializer = userCredential,
                ApplicationName = "Calendar API Sample",
            };

            return new CalendarService(initializer);
        }
    }
}
