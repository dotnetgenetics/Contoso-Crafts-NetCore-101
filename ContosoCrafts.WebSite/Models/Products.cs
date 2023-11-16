using System.Text.Json.Serialization;
using System.Text.Json;

namespace ContosoCrafts.WebSite.Models
{
   public class Product
   {
      public string Id { get; set; } = string.Empty;
      public string Maker { get; set; } = string.Empty;

      [JsonPropertyName("img")]
      public string Image { get; set; } = string.Empty;

      public string Url { get; set; } = string.Empty;
      public string Title { get; set; } = string.Empty;
      public string Description { get; set; } = string.Empty;
      public int[] Ratings { get; set; } = [];

      public override string ToString() => JsonSerializer.Serialize<Product>(this);
   }
}
