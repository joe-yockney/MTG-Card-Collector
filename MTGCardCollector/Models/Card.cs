using System.Text.Json.Serialization;

namespace MTGCardCollector.Models
{
    public class Card
    {
        public string? name { get; set; }
        public string? manaCost { get; set; }
        public double cmc { get; set; }
        public List<string>? colors { get; set; }
        public List<string>? colorIdentity { get; set; }
        public string? type { get; set; }
        public List<string>? types { get; set; }
        public string? rarity { get; set; }
        public string? set { get; set; }
        public string? setName { get; set; }
        public string? text { get; set; }
        public string? flavor { get; set; }
        public string? artist { get; set; }
        public string? number { get; set; }
        public string? layout { get; set; }
        public string? multiverseid { get; set; }
        public string? imageUrl { get; set; }
        public List<string>? printings { get; set; }
        public string? originalText { get; set; }
        public string? originalType { get; set; }
        public string? id { get; set; }
        public List<string>? subtypes { get; set; }
        public string? power { get; set; }
        public string? toughness { get; set; }
        public List<string>? variations { get; set; }
        public List<string>? supertypes { get; set; }
    }

}
