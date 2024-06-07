using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService 
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Weather?> GetWeatherAsync(string city)
        {
            var apiKey = "12b2444e29c6d0795b87c8931ee7b149";
            var apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=imperial";
            var response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var WeatherAPIDetails = JsonSerializer.Deserialize<WeatherAPIDetails>(json);
                var weather = new Weather
                {
                    BasicDescription = WeatherAPIDetails.Weather?[0].Main ?? "",
                    DetailedDescription = WeatherAPIDetails.Weather?[0].Description ?? "",
                    Temperature = WeatherAPIDetails.Main?.Temp ?? 0.0,
                    MinimumTemperature = WeatherAPIDetails.Main?.Temp_Min ?? 0.0,
                    MaximumTemperature = WeatherAPIDetails.Main?.Temp_Max ?? 0.0,
                    Humidity = WeatherAPIDetails.Main?.Humidity ?? 0.0
                };

                return weather;
            }
            return null;
        }
    }
}
 