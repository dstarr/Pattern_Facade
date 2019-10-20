using Facade.Entities;

namespace Facade.Services
{
    public class WeatherService
    {
        public int GetTempFahrenheit(City city, State state)
        {
            // call to service or db would go here
            
            return 53;
        }

        public int GetTempCelcius(City city, State state)
        {
            // call to service or db would go here
            
            return 11;
        }
    }
}