using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Events.Any()) return;

            var events = new List<Event>
            {
                new Event
                {
                    Title = "Past Event 1",
                    DateFrom = DateTime.UtcNow.AddMonths(-2),
                    DateTo = DateTime.UtcNow.AddMonths(+2),
                    BusinessUnit = "CSuit",
                    Description = "Event 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Event
                {
                    Title = "Past Event 2",
                    DateFrom = DateTime.UtcNow.AddMonths(5),
                    DateTo = DateTime.UtcNow.AddMonths(6),
                    BusinessUnit = "Dev",
                    Description = "Event 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                },
                new Event
                {
                    Title = "Future Event 1",
                    DateFrom = DateTime.UtcNow.AddMonths(1),
                    DateTo = DateTime.UtcNow.AddMonths(2),
                    BusinessUnit = "Marketing",
                    Description = "Event 1 month in future",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                },
                new Event
                {
                    Title = "Future Event 2",
                    DateFrom = DateTime.UtcNow.AddMonths(3),
                    DateTo = DateTime.UtcNow.AddMonths(4),
                    BusinessUnit = "Logistics",
                    Description = "Event 2 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                },
                new Event
                {
                    Title = "Future Event 3",
                    DateFrom = DateTime.UtcNow.AddMonths(12),
                    DateTo = DateTime.UtcNow.AddMonths(13),
                    BusinessUnit = "HR",
                    Description = "Event 3 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another pub",
                },
                new Event
                {
                    Title = "Future Event 4",
                    DateFrom = DateTime.UtcNow.AddMonths(7),
                    DateTo = DateTime.UtcNow.AddMonths(8),
                    BusinessUnit = "CSuit",
                    Description = "Event 4 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet another pub",
                },
                new Event
                {
                    Title = "Future Event 5",
                    DateFrom = DateTime.UtcNow.AddMonths(5),
                    DateTo = DateTime.UtcNow.AddMonths(9),
                    BusinessUnit = "HR",
                    Description = "Event 5 months in future",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another pub",
                },
                new Event
                {
                    Title = "Future Event 6",
                    DateFrom = DateTime.UtcNow.AddMonths(2),
                    DateTo = DateTime.UtcNow.AddMonths(6),
                    BusinessUnit = "Dev",
                    Description = "Event 6 months in future",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                },
                new Event
                {
                    Title = "Future Event 7",
                    DateFrom = DateTime.UtcNow.AddMonths(1),
                    DateTo = DateTime.UtcNow.AddMonths(1),
                    BusinessUnit = "Data",
                    Description = "Event 2 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },
                new Event
                {
                    Title = "Future Event 8",
                    DateFrom = DateTime.UtcNow.AddMonths(4),
                    DateTo = DateTime.UtcNow.AddMonths(7),
                    BusinessUnit = "BA",
                    Description = "Event 8 months in future",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                }
            };

            await context.Events.AddRangeAsync(events);
            await context.SaveChangesAsync();
        }
    }
}