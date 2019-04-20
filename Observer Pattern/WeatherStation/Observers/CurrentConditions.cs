using System;
using WeatherStation.Base;

namespace WeatherStation.Observers
{
    public class CurrentConditionsDisplay:IObserver
    {
        private float temp;
        private float humidity;
        private float pressure;
        public ISubject WeatherData;
        public CurrentConditionsDisplay(ISubject WeatherData)
        {
            this.WeatherData = WeatherData;
            WeatherData.registerObserver(this);
        }

        public void update(float temp, float humidity, float pressure){
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            System.Console.WriteLine(String.Format("Current Conditions: Temperature = {0}, Pressure = {1}, Humidity = {2}",temp,pressure,humidity));
        }
    }
}