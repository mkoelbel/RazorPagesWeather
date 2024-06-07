using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class Weather
    {
        public string? BasicDescription { get; set; }
        public string? DetailedDescription { get; set; }
        public double Temperature { get; set; }
        public double MinimumTemperature { get; set; }
        public double MaximumTemperature { get; set; }
        public double Humidity { get; set; }
    }

    public class WeatherAPIDetails
    {
        [JsonPropertyName("weather")]
        public WeatherWords[]? Weather { get; set; }
        
        [JsonPropertyName("main")]
        public WeatherNumbers? Main { get; set; }
    }

    public class WeatherWords
    {
        [JsonPropertyName("main")]
        public string? Main { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }

    public class WeatherNumbers
    {
        [JsonPropertyName("temp")]
        public double? Temp { get; set; }
        
        [JsonPropertyName("temp_min")]
        public double? Temp_Min { get; set; }
        
        [JsonPropertyName("temp_max")]
        public double? Temp_Max { get; set; }
        
        [JsonPropertyName("humidity")]
        public double? Humidity { get; set; }
    }
}