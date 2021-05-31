namespace MtGDB.Models
{
    public class Card
    {
        public string Name { get; set; }
        public string Edition { get; set; }
        public int Quantity { get; set; }
        public Rarity Rarity { get; set; }
    }
}