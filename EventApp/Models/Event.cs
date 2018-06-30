using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApp.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Guests { get; set; }
        public string Description { get; set; }
    }
}