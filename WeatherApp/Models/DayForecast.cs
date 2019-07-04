using System;
using Newtonsoft.Json;

namespace WeatherApp.Models
{
    public class DayForecast
    {
        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }

       
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

      
        [JsonProperty(PropertyName = "temperatureHigh")]
        public double? TemperatureHigh { get; set; }

       
        [JsonProperty(PropertyName = "temperatureLow")]
        public double? TemperatureLow { get; set; }

      
        [JsonProperty(PropertyName = "time")]
        public long TimeUnix { get; set; }

        public DateTime Date => UnixTimestampToDateTime(TimeUnix);

        public static DateTime UnixTimestampToDateTime(double unixTime)
        {
            DateTime unixStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            long unixTimeStampInTicks = (long)(unixTime * TimeSpan.TicksPerSecond);
            return new DateTime(unixStart.Ticks + unixTimeStampInTicks, System.DateTimeKind.Utc);
        }
    }
}