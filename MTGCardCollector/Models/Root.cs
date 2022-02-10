namespace MTGCardCollector.Models
{
    public class Root
    {
        public Card? Card { get; set; }
        public List<Card>? Cards { get; set; }
        public List<Set>? Sets { get; set; }
    }
}
