namespace WebEngineering.Models
{
    public class ProduktViewModel
    {
        public Produkt? Produkt { get; set; }
        public List<ProduktPlus> Produkte { get; set; }
        public List<Datapoint> Datapoints { get; set; }

        public ProduktViewModel()
        {
            Produkte = new List<ProduktPlus>();
            Datapoints = new List<Datapoint>();
        }
    }
}
