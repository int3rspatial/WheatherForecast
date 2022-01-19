using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{    
    public class Responce
    {
        /// <summary>
        /// Geographical coordinates of the location (latitude)
        /// </summary>
        public double lat { get; set; }
        /// <summary>
        /// Geographical coordinates of the location (longitude)
        /// </summary>
        public double lon { get; set; }
        /// <summary>
        /// Timezone name for the requested location
        /// </summary>
        public string timezone { get; set; }
        /// <summary>
        /// Shift in seconds from UTC
        /// </summary>
        public int timezone_offset { get; set; }
        /// <summary>
        /// Hourly forecast weather
        /// </summary>
        public List<Hourly> hourly { get; set; }
    }    
    public class Hourly
    {
        /// <summary>
        /// Time of the forecasted data, Unix timestamp
        /// </summary>
        public int dt { get; set; }
        /// <summary>
        /// Temperature. Units – in metric system: Celsius
        /// </summary>
        public double temp { get; set; }
        /// <summary>
        /// Temperature. This accounts for the human perception of weather. Units – in metric system: Celsius
        /// </summary>
        public double feels_like { get; set; }
        /// <summary>
        ///  Atmospheric pressure on the sea level, hPa
        /// </summary>
        public int pressure { get; set; }
        /// <summary>
        /// Humidity, %
        /// </summary>
        public int humidity { get; set; }
        /// <summary>
        ///  Atmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense and dew can form. 
        ///  Units – in metric system: Celsius
        /// </summary>
        public double dew_point { get; set; }
        /// <summary>
        /// UV index
        /// </summary>
        public double uvi { get; set; }
        /// <summary>
        /// Cloudiness, %
        /// </summary>
        public int clouds { get; set; }
        /// <summary>
        /// Average visibility, metres
        /// </summary>
        public int visibility { get; set; }
        /// <summary>
        /// Wind speed. Units – in metric system: Celsius
        /// </summary>
        public double wind_speed { get; set; }
        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        public int wind_deg { get; set; }
        /// <summary>
        /// Wind gust. Units — in metric system: metre/sec
        /// </summary>
        public double wind_gust { get; set; }
        /// <summary>
        /// Additional data about weather
        /// </summary>
        public List<Weather> weather { get; set; }
        /// <summary>
        /// Probability of precipitation
        /// </summary>
        public double pop { get; set; }
        public Rain rain { get; set; }
    }
    public class Weather
    {
        /// <summary>
        /// Wheather condition id
        /// </summary>
        /// https://openweathermap.org/weather-conditions#Weather-Condition-Codes-2
        public int id { get; set; }
        /// <summary>
        /// Group of weather parameters (Rain, Snow, Extreme etc.)
        /// </summary>
        public string main { get; set; }
        /// <summary>
        /// Weather condition within the group
        /// </summary>
        /// https://openweathermap.org/weather-conditions#Weather-Condition-Codes-2
        public string description { get; set; }
        /// <summary>
        /// Weather icon id
        /// </summary>
        public string icon { get; set; }
    }

    public class Rain
    {
        public double _1h { get; set; }
    }




}
