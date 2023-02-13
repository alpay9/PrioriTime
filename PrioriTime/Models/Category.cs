using System.Text.Json;
using System.Text.Json.Serialization;

namespace PrioriTime.Models
{
    public class Category
    {
        //[JsonPropertyName("id")]
        public int Id { get; set; }
        //[JsonPropertyName("name")]
        public string Name { get; set; }
        //[JsonPropertyName("color")]
        public string Color { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Category>(this);
        }
    }
}
