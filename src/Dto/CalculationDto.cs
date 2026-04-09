using System.Text.Json.Serialization;

namespace CalculadoraTeste.Dto
{
    public class CalculationDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("valorA")]
        public int ValueA { get; set; }

        [JsonPropertyName("valorB")]
        public int ValueB { get; set; }

        [JsonPropertyName("operacao")]
        public string Operation { get; set; } = string.Empty;

        [JsonPropertyName("resultado")]
        public int Result { get; set; }

        [JsonPropertyName("dataCalculo")]
        public DateTime CreatedAt { get; set; }
    }
}