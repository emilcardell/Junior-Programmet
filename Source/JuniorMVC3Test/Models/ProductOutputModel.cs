using System.Collections.Generic;

namespace JuniorMVC3Test.Models
{
    public class ProductOutputModel
    {
        public ProductOutputModel()
        {
            RelateradeProdukter = new List<string>() { "Hatt", "Hus", "Hund" };
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> RelateradeProdukter { get; set; }
        public string BildUrl { get; set; }
        public bool ShowRelatedProductList { get { return RelateradeProdukter.Count > 0; } }
    }
}