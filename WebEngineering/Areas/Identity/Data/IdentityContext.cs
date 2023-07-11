﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebEngineering.Areas.Identity.Data;
using WebEngineering.Models;

namespace WebEngineering.Data;

public class IdentityContext : IdentityDbContext<User>
{
    public DbSet<Produkt> Produkte { get; set; }
    public DbSet<Bestellung> Bestellungen { get; set; }
    public DbSet<Lieferung> Lieferungen { get; set; }
    public IdentityContext(DbContextOptions<IdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

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
        for (int i = -1; i >= -80; i--)
        {
            Random random = new Random();
            string productName = $"{materials[random.Next(materials.Count)]}{parts[random.Next(parts.Count)]}";

            DateTime startDate = new DateTime(2022, 1, 1);
            DateTime endDate = new DateTime(2023, 12, 31);

            TimeSpan timeSpan = endDate - startDate;
            TimeSpan randomTimeSpan = new TimeSpan(0, random.Next(0, (int)timeSpan.TotalMinutes), 0);

            DateTime randomDate = startDate + randomTimeSpan; //used for Bestellung

            int randomWeeks = random.Next(1, 3);
            TimeSpan randomIncrement = TimeSpan.FromDays(randomWeeks * 7);
            DateTime lieferungRandomDate = randomDate + randomIncrement; //used for Lieferung


            Produkt produkt = new Produkt()
            {
                Id = i,
                Name = productName
            };

            Bestellung bestellung = new Bestellung()
            {
                Id = i,
                Date = randomDate,
                ProduktId = produkt.Id,
                Menge = random.Next(1, 300)
            };

            Lieferung lieferung = new Lieferung()
            {
                Id = i,
                Date = lieferungRandomDate,
                ProduktId = produkt.Id,
                BestellungId = bestellung.Id,
                Menge = bestellung.Menge
            };

            builder.Entity<Produkt>().HasData(produkt); // add to DB
            builder.Entity<Bestellung>().HasData(bestellung); // add to DB
            builder.Entity<Lieferung>().HasData(lieferung); // add to DB

            // menge yanlis, Lieferung klass'i mengeyi Bestellung classindan direk almali o bestellung icin!  
        }
    }
}