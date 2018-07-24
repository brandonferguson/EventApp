using System;
using System.ComponentModel.DataAnnotations;


namespace EventApp.Models
{
    public class Event
    {
        public int EventId { get; set; }
        //Makes the Event Name a required field and limits the character length to 50 char
        [Required, MaxLength(50, ErrorMessage ="Limit 50 characters")]
        public string EventName { get; set; }
        //DateTime is an optional field
        public DateTime? Date { get; set; }
        public string Location { get; set; }
        public string Guests { get; set; }
        //Limits the length of the Description to 2000 characters
        [MaxLength(2000, ErrorMessage = "The Description cannot be longer than 2000 characters.")]
        public string Description { get; set; }
    }
}