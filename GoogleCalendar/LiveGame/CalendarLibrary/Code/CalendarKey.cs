using CalendarLibrary.Interfaces;
using CalendarLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarLibrary.Code
{
    public class CalendarKey : ICalendarKey
    {
        protected string _path = @"C:\Users\pkubo\OneDrive\Dokumenty\GitHub\_Klucze\KalendarzGoogle\client_secret.json";
        protected CalendarClientJsonKey _key;

        public CalendarKey()
        {
            string json = System.IO.File.ReadAllText(_path);

            _key = Newtonsoft.Json.JsonConvert.DeserializeObject<CalendarClientJsonKey>(json);
        }

        public string GetClientId()
        {
            return _key.installed.client_id;
        }
        public string GetClientSecret()
        {
            return _key.installed.client_secret;
        }

    }
}
