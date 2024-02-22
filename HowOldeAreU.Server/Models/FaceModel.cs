using System.Text.Json.Serialization;

namespace HowOldeAreU.Server.Models
{
    public class FaceModel
    {
        [JsonPropertyName("age")]
        public double ? Age { get; set; }

        [JsonPropertyName("score")]
        public double ? Score { get; set; }

        [JsonPropertyName("bbox")]
        public List<double> ? Bbox { get; set; }

        [JsonPropertyName("class")]
        public string ? Class  { get; set; }

        [JsonPropertyName("faces")]
        public List<double> ? Faces { get; set; }

        [JsonPropertyName("status")]
        public string ? Status { get; set; }
    }
}
