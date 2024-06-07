// using System;
// using System.Net.Http;
// using System.Text.Json;
// using System.Text.Json.Serialization;
// using System.Threading.Tasks;


// class Program
// {
//     static async Task Main(string[] args)
//     {
//         string apiKey = "12b2444e29c6d0795b87c8931ee7b149";
//         string city = "Houston, US"; // Change this to the desired city

//         string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=imperial";

//         using (HttpClient client = new HttpClient())
//         {
//             HttpResponseMessage response = await client.GetAsync(apiUrl);

//             if (response.IsSuccessStatusCode)
//             {
//                 string json = await response.Content.ReadAsStringAsync();
//                 WeatherDetails weather = JsonSerializer.Deserialize<WeatherDetails>(json);

//                 string major_description = weather.Weather?[0].Main ?? "";
//                 string description = weather.Weather?[0].Description ?? "";
//                 double temp = weather.Main?.Temp ?? 0.0;
//                 double temp_max = weather.Main?.Temp_Min ?? 0.0;
//                 double temp_min = weather.Main?.Temp_Max ?? 0.0;
//                 double humidity = weather.Main?.Humidity ?? 0.0;

//                 Console.WriteLine($"Weather in {city}:");
//                 Console.WriteLine($"Overall: {major_description}");
//                 Console.WriteLine($"Description: {description}");
//                 Console.WriteLine($"Temperature: {temp}°F");
//                 Console.WriteLine($"Min Temperature: {temp_max}°F");
//                 Console.WriteLine($"Max Temperature: {temp_min}°F");
//                 Console.WriteLine($"Humidity: {humidity}%");
//                 // Console.WriteLine(json);
//             }
//             else
//             {
//                 Console.WriteLine($"Failed to fetch weather data. Status code: {response.StatusCode}");
//             }
//         }
//     }
// }
