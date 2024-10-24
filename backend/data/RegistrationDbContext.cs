using Microsoft.EntityFrameworkCore;
using RegistrationProject.Models;

namespace RegistrationProject.Data
{
    public class RegistrationDbContext : DbContext
    {
        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
    }
}