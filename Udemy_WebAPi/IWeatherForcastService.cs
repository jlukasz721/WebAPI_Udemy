using System.Collections.Generic;

namespace Udemy_WebAPi
{
    public interface IWeatherForcastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}
