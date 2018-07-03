using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EventApp.Models;

namespace EventApp.DAL
{
    public class EventInit : System.Data.Entity. DropCreateDatabaseIfModelChanges<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            var events = new List<Event>
            {
                new Event{EventName="Beer Brew Day",Date=DateTime.Parse("2018-01-20"),Location="Joe's House",Description="Come drink and brew beer with us!",Guests="Joe, Michael, Wes, Rose"},
                new Event{EventName="Josh's Birthday Dinner",Date=DateTime.Parse("2018-02-07"),Location="Selina's Tavern",Description="Josh is older and needs to eat food to celebrate",Guests="Josh, Dunca, Joe, Michael, Wes, Rose"},
                new Event{EventName="Boardgame Day",Date=DateTime.Parse("2018-01-07"),Location="Joe's House",Description="We'll be playing boardgames and drinking",Guests="Guy, Joe, Wes, Rose"}
            };

            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();
        }
    }
}