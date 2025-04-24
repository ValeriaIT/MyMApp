using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class DbInitialiser
    {
        public static async Task SeedData(AppDbContext context)
        {
            if (!context.Topics.Any())
            {
                var topics = new List<Topic>
                {
                    new Topic { Title = "Topic 1", Description = "Description 1", Category = "Category 1" },
                    new Topic { Title = "Topic 2", Description = "Description 2", Category = "Category 2" },
                    new Topic { Title = "Topic 3", Description = "Description 3", Category = "Category 3" }
                };

                await context.Topics.AddRangeAsync(topics);
                await context.SaveChangesAsync();
            }
        }
    }
}
