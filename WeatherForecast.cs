using System;

namespace PlanningGeneratorAPI
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; } 
        /// test

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
