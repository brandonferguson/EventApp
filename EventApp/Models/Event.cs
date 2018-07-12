using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventApp.Models
{
    public class Event
    {
        public int EventId { get; set; }
        [Required, MaxLength(50, ErrorMessage ="Limit 50 characters")]
        public string EventName { get; set; }
        public DateTime? Date { get; set; }
        public string Location { get; set; }
        public string Guests { get; set; }
        [MaxLength(2000, ErrorMessage = "The Description cannot be longer than 2000 characters.")]
        public string Description { get; set; }
    }
}