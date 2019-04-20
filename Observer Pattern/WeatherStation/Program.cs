using System;
using WeatherStation.Base;
using WeatherStation.Observers;
namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay current = new CurrentConditionsDisplay(weatherData);

            weatherData.setMeasurements(80,65,30.4f);
            weatherData.setMeasurements(82,70,39.2f);
            
        }
    }
}
