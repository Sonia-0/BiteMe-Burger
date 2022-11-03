using System.Text.Json;
using System.Text.Json.Serialization;

namespace BiteMeBurger.model
{
    public class burger
    {
        [JsonPropertyName("id")]
        public int burger_id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<burger>(this);
        }
    }
}
