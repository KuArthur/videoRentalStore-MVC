using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using videoRentalStore.Models;

namespace videoRentalStore.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Video> Videos { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}

