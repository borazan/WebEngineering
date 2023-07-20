using System.Text.Json.Serialization;

namespace WebEngineering.Models
{
    public class Produkt
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Bestellung>? Bestellungen { get; set; }
        [JsonIgnore]
        public virtual ICollection<Lieferung>? Lieferungen { get; set; }

    }
}
