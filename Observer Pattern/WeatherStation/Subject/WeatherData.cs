using System;
using System.Collections.Generic;

namespace WeatherStation.Base
{
    public class WeatherData:ISubject
    {
        public List<IObserver> Observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        public void registerObserver(IObserver o){
            Observers.Add(o);
        }

        public void removeObserver(IObserver o){
            int i = Observers.IndexOf(o);
            if( i>=0 ){
                Observers.Remove(o);
            }
        }
        public void notifyObservers(){
            foreach (IObserver o in Observers)
            {
                o.update(temperature,humidity,pressure);
            }
        }

        public void setMeasurements(float temp, float humidity, float pressure){
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            notifyObservers();
        }
    }
}