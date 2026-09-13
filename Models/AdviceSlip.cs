using System.Text.Json.Serialization;

namespace ConsumerAdviceApi.Models;

public class AdviceSlip
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("advice")]
    public string? Advice { get; set; }
}
