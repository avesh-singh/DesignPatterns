using System;

namespace WeatherStation.Base
{
    public interface IObserver
    {
        void update(float temp, float humidity, float pressure);
    }
}