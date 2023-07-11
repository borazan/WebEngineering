namespace WebEngineering.Models
{
    public class Lieferung
    {
        public int Id { get; set; }
        public Produkt Produkt { get; set; }
        public int ProduktId { get; set; }
        public Bestellung bestellung { get; set; }
        public int BestellungId { get; set; }
        public DateTime Date { get; set; }
        public int Menge { get; set; }
    }
}
