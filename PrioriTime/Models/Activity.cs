using System.Text.Json;
using System.Text.Json.Serialization;

namespace PrioriTime.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        [JsonPropertyName("start")]
        public int StartTime { get; set; }
        [JsonPropertyName("end")]
        public int EndTime { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Activity>(this);
        }

    }
}
