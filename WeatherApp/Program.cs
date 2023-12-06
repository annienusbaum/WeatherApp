using Newtonsoft.Json.Linq;
using WeatherApp;

string key = File.ReadAllText("appsettings.json");
string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();


Console.WriteLine("Please enter your city");
var cityname = Console.ReadLine();

var apiCall = $"https://api.openweathermap.org/data/2.5/weather?q={cityname}&appid={APIKey}&units=imperial\n";

Console.WriteLine();

Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location.");

