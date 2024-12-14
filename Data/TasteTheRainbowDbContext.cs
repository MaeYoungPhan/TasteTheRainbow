using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TasteTheRainbow.Models;
using Microsoft.AspNetCore.Identity;

namespace TasteTheRainbow.Data;
public class TasteTheRainbowDbContext : IdentityDbContext<IdentityUser>
{
    private readonly IConfiguration _configuration;
    // public DbSet<Bike> Bikes { get; set; }
    // public DbSet<BikeType> BikeTypes { get; set; }
    // public DbSet<WorkOrder> WorkOrders { get; set; }
    // public DbSet<Owner> Owners { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }

    public TasteTheRainbowDbContext(DbContextOptions<TasteTheRainbowDbContext> context, IConfiguration config) : base(context)
    {
        _configuration = config;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
            Name = "Admin",
            NormalizedName = "admin"
        });

        modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
        {
            Id = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
            UserName = "Administrator",
            Email = "admina@strator.comx",
            PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, _configuration["AdminPassword"])
        });

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = "c3aaeb97-d2ba-4a53-a521-4eea61e59b35",
            UserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f"
        });
        modelBuilder.Entity<UserProfile>().HasData(new UserProfile
        {
            Id = 1,
            IdentityUserId = "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
            FirstName = "Admina",
            LastName = "Strator",
            Address = "101 Main Street",
        });

        // modelBuilder.Entity<Owner>().HasData(new Owner[]
        // {
        //     new Owner
        //     {
        //         Id = 1,
        //         Email="bike.owner@mail.comx",
        //         Name="Bike Owner",
        //         Address="421 Tenth Street",
        //         Telephone="123-456-7890"
        //     },
        // });
    }
}