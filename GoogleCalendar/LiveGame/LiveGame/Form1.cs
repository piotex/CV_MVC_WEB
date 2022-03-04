using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarLibrary;
using CalendarLibrary.Models;

namespace LiveGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalendarOperationsManager c = new CalendarOperationsManager();

            string title = "test_title";
            string colorId = "8";
            DateTime start = DateTime.Now.AddHours(-1); 
            DateTime end = DateTime.Now;

            c.AddEventToCalendar(new CalendarEvent(title, start, end, colorId));
        }
    }
}


/*
    string Basil = "10";
    string Tomato = "11";
    string Blueberry = "9";
    string Graphite = "8";
    string Peacock = "7";
    string Tangerine = "6";
    string Banana = "5";
    string Flamingo = "4";
    string Grape = "3";
    string Sage = "2";
    string Lavender = "1";
*/
