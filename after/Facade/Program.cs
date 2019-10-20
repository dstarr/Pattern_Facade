using System;
using Facade.Entities;
using Facade.Services;

namespace Facade
{
    public static class Program
    {
        static void Main(string[] args)
        {
            const string zipCode = "98074";
            
            GeoLookupService geoLookupService = new GeoLookupService();
            WeatherService weatherService = new WeatherService();
            ConverterService converterService = new ConverterService();
            
            IWeatherFacade weatherFacade = new WeatherFacade(converterService, geoLookupService, weatherService);
            WeatherFacadeResults results = weatherFacade.GetTempInCity(zipCode);
            
            // bring the result of all service calls together
            Console.WriteLine("The current temperature is {0}F/{1}C in {2}, {3}",
                                results.Fahrenheit,
                                results.Celsius,
                                results.City.Name,
                                results.State.Name);

        }
    }
}