using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebEngineering.Areas.Identity.Data;
using WebEngineering.Models;
using System.Reflection.Emit;
using System;

namespace WebEngineering.Data;

public class IdentityContext : IdentityDbContext<User>
{
    public DbSet<Produkt> Produkte { get; set; }
    public DbSet<Bestellung> Bestellungen { get; set; }
    public DbSet<Lieferung> Lieferungen { get; set; }
    public DbSet<WebEngineering.Models.ViewModel>? ViewModel { get; set; }
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
        User user1 = new User() { Id = Guid.NewGuid().ToString(), UserName = "demo01@gmail.com" }; // user creation
        user1.NormalizedUserName = user1.UserName.ToUpper();
        user1.PasswordHash = passwordHasher.HashPassword(user1, "demo01");
        builder.Entity<User>().HasData(user1);

        User user2 = new User() { Id = Guid.NewGuid().ToString(), UserName = "demo02@gmail.com" }; // user creation
        user2.NormalizedUserName = user2.UserName.ToUpper();
        user2.PasswordHash = passwordHasher.HashPassword(user2, "demo02");
        builder.Entity<User>().HasData(user2);

        User user3 = new User() { Id = Guid.NewGuid().ToString(), UserName = "demo03@gmail.com" }; // user creation
        user3.NormalizedUserName = user3.UserName.ToUpper();
        user3.PasswordHash = passwordHasher.HashPassword(user3, "demo03");
        builder.Entity<User>().HasData(user3);

        User user4 = new User() { Id = Guid.NewGuid().ToString(), UserName = "demo04@gmail.com" }; // user creation
        user4.NormalizedUserName = user4.UserName.ToUpper();
        user4.PasswordHash = passwordHasher.HashPassword(user4, "demo04");
        builder.Entity<User>().HasData(user4);

        User admin = new User() { Id = Guid.NewGuid().ToString(), UserName = "admin@gmail.com" }; // user creation
        admin.NormalizedUserName = admin.UserName.ToUpper();
        admin.PasswordHash = passwordHasher.HashPassword(admin, "admin");
        builder.Entity<User>().HasData(admin);

        IdentityRole role = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Manager" }; // role creation
        role.NormalizedName = role.Name.ToUpper();
        builder.Entity<IdentityRole>().HasData(role);

        IdentityUserRole<string> userRole = new IdentityUserRole<string>() { RoleId = role.Id, UserId = admin.Id }; // assign a user a role
        builder.Entity<IdentityUserRole<string>>().HasData(userRole);




        List<string> materials = new List<string>()
{
            "Stahl",
            "Metall",
            "Glas",
            "Kunststoff",
            "Beton",
            "Aluminium",
            "Keramik",
            "Papier",
            "Textil",
            "Gummi",
            "Stein",
            "Silber",
            "Gold",
            "Kupfer",
            "Bronze",
            "Titan",
            "Plexiglas",
            "Acryl"
};
        List<string> parts = new List<string>()
{
            "schrauben",
            "bolzen",
            "platten",
            "muttern",
            "unterlegscheiben",
            "federn",
            "zahnräder",
            "dichtungen",
            "ventile",
            "rohre",
            "kabel",
            "schalter",
            "sensoren",
            "pumpen",
            "filter",
            "riemen",
            "gehäuse",
};
        List<Produkt> products = new List<Produkt>();
        Random random = new Random();

        for (int i = -1; i >= -20; i--) // generate random product list
        {
            string productName = $"{materials[random.Next(materials.Count)]}{parts[random.Next(parts.Count)]}";
            Produkt produkt = new Produkt()
            {
                Id = i,
                Name = productName
            };
            products.Add(produkt); // can't access DbSet directly on model creation
            builder.Entity<Produkt>().HasData(produkt); // add to DB

        }

        for (int i = -1; i >= -20; i--) // generate Lieferungen
        {
            Produkt produkt = products[random.Next(products.Count())];
            DateTime lieferungRandomDate = getRandomDate();

            Lieferung lieferung = new Lieferung()
            {
                Id = i,
                Date = lieferungRandomDate,
                ProduktId = produkt.Id,
                Menge = random.Next(500, 5000)
            };

            builder.Entity<Lieferung>().HasData(lieferung); // add to DB 
        }

        for (int i = -1; i >= -80; i--) // generate Bestellungen
        {
            Produkt produkt = products[random.Next(products.Count())];

            DateTime bestellungRandomDate = getRandomDate();
            Bestellung bestellung = new Bestellung()
            {
                Id = i,
                Date = bestellungRandomDate,
                ProduktId = produkt.Id,
                Menge = random.Next(1, 300)
            };

            builder.Entity<Bestellung>().HasData(bestellung); // add to DB
        }
    }
    public DateTime getRandomDate(int startYear = 2022, int endYear = 2023)
    {
        Random random = new Random();
        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);

        TimeSpan timeSpan = endDate - startDate;
        TimeSpan randomTimeSpan = new TimeSpan(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);

        return (startDate + randomTimeSpan);
    }
}
