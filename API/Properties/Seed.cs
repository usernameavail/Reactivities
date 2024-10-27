using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var activies = new List<Activity>
            {
                new Activity
                {
                    Title = "Past Activity 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Activity 2 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },

                new Activity
                {
                    Title = "Past Activity 2",
                    Date = DateTime.UtcNow.AddMonths(-1),
                    Description = "Activity 1 month ago",
                    Category = "culture",
                    City = "Paris",
                    Venue = "Louvre",
                },

                new Activity
                {
                    Title = "Future Activity 1",
                    Date = DateTime.UtcNow.AddMonths(1),
                    Description = "Activity 3 months from now",
                    Category = "culture",
                    City = "London",
                    Venue = "Natural History Museum",
                },
                
                new Activity
                {
                    Title = "Future Activity 2",
                    Date = DateTime.UtcNow.AddMonths(2),
                    Description = "Activity 2 months from now",
                    Category = "music",
                    City = "London",
                    Venue = "O2 Arena",
                },

                new Activity
                {
                    Title = "Future Activity 3",
                    Date = DateTime.UtcNow.AddMonths(3),
                    Description = "Activity 3 months from now",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another Pub",
                },

                 new Activity
                {
                    Title = "Future Activity 4",
                    Date = DateTime.UtcNow.AddMonths(4),
                    Description = "Activity 4 months from now",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet Another Pub",
                },

                 new Activity
                {
                    Title = "Future Activity 5",
                    Date = DateTime.UtcNow.AddMonths(5),
                    Description = "Activity 5 months from now",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just Another Pub",
                },

                 new Activity
                {
                    Title = "Future Activity 6",
                    Date = DateTime.UtcNow.AddMonths(6),
                    Description = "Activity 6 months from now",
                    Category = "music",
                    City = "London",
                    Venue = "Roundhouse Camden",
                },

                 new Activity
                {
                    Title = "Future Activity 7",
                    Date = DateTime.UtcNow.AddMonths(7),
                    Description = "Activity 7 months from now",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },

                 new Activity
                {
                    Title = "Future Activity 8",
                    Date = DateTime.UtcNow.AddMonths(8),
                    Description = "Activity 8 months from now",
                    Category = "film",
                    City = "London",
                    Venue = "Cinema",
                }
            };
            await context.Activities.AddRangeAsync(activies);
            await context.SaveChangesAsync();
        }
    }
}