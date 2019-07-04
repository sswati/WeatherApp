using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class Forecast
    {
        
        [JsonProperty(PropertyName = "currently")]
        public DayForecast Currently { get; set; }

        
        [JsonProperty(PropertyName = "daily")]
        public DailyForecast Daily { get; set; }

        
        [JsonProperty(PropertyName = "timezone")]
        public string TimeZone { get; set; }
    }
}