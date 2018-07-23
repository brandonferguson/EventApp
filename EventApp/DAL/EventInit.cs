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
                new Event{EventName="Beer Brew Day",
                    Date =DateTime.Parse("2018-01-20"),
                    Location ="9900 S Tiverton Drive",
                    Description ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Guests="Joe, Michael, Wes, Rose"},
                new Event{EventName="Josh's Birthday Dinner",
                    Date =DateTime.Parse("2018-02-07"),
                    Location ="1725 Priarie Circle",
                    Description ="Josh is older and needs to eat food to celebrate.  Join us he celebrates another year of not dying.  Burgers and snacks will be provided.  No kids.  You should bring lots of booze.",
                    Guests ="Josh, Dunca, Joe, Michael, Wes, Rose"},
                new Event{EventName="Boardgame Day",
                    Date =DateTime.Parse("2018-01-07"),
                    Location ="9420 Corporate Campus Way",
                    Description ="We'll be playing boardgames and drinking.  A poll will be sent out later to take stock of which games arae available and which people are interested in playing.  The goal is to have 10-15 people playing two to three different games.  Please keep in mind that each game is expected to take a minimum of an hour.",
                    Guests ="Guy, Joe, Wes, Rose"}
            };

            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();
        }
    }
}