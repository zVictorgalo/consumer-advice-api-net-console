using System.Text.Json.Serialization;

namespace ConsumerAdviceApi.Models;

public class AdviceResponse
{
    [JsonPropertyName("slip")]
    public AdviceSlip? Slip { get; set; }
}
