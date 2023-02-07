using System.Text.Json.Serialization;
namespace BlazorApp2.Data;

// Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
public class ClimatologicalData
{
    public string? Date { get; set; }
    public int Maximum { get; set; }
    public int Minimum { get; set; }

    public int TempSpread
    {
        get
        {
            return Maximum - Minimum;
        }
    }
    public double Average { get; set; }
    public double Departure { get; set; }
    public string? Hdd { get; set; }
    public string? Cdd { get; set; }
    public string? Precipitation { get; set; }

    [JsonPropertyName("New Snow")]
    public string? NewSnow { get; set; }

    [JsonPropertyName("Snow Depth")]
    public double SnowDepth { get; set; }
}