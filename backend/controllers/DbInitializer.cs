using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RegistrationProject.Models;
using System;
using System.Linq;

namespace RegistrationProject.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RegistrationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<RegistrationDbContext>>()))
            {
                // Look for any addresses.
                if (context.Addresses.Any())
                {
                    return;   // DB has been seeded
                }

                var addresses = new Address[]
                {
                    new Address{Street="123 Main St", City="Anytown", State="AN", ZipCode="12345"},
                    new Address{Street="456 Elm St", City="Othertown", State="OT", ZipCode="67890"},
                    // Add more addresses as needed
                };

                foreach (var address in addresses)
                {
                    context.Addresses.Add(address);
                }

                context.SaveChanges();
            }
        }
    }
}