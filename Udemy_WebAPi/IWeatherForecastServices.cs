using System.Collections.Generic;

namespace Udemy_WebAPi
{
    public interface IWeatherForecastServices
    {
        IEnumerable<WeatherForecast> Get();
    }
}