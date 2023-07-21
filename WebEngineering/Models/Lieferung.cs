﻿namespace WebEngineering.Models
{
    public class Lieferung
    {
        public int Id { get; set; }
        public int? ProduktId { get; set; }
        public virtual Produkt? Produkt { get; set; }
        public DateTime Date { get; set; }
        public int Menge { get; set; }
    }
}
