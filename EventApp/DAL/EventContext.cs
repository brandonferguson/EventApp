using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EventApp.DAL
{
    public class EventContext : DbContext
    {
        public EventContext() : base("EventContext")
        {

        }

        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Event>().Property(b => b.EventName).IsRequired();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}