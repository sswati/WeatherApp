using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class DailyForecast
    {
        // List of <see cref="WeatherApp.Models.DayForecast"/>, ordered by time, which together describe the weather conditions at the requested location over time.
      
        [JsonProperty(PropertyName = "data")]
        public List<DayForecast> Data { get; set; }
    }
}