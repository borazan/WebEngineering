using Microsoft.EntityFrameworkCore;

namespace WebEngineering.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Produkt> Produkte { get; set; }
        public DbSet<Bestellung> Bestellungen { get; set; }
        public DbSet<Lieferung> Lieferungen { get; set; }

    }
}
