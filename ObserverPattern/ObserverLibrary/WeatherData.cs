using ObserverLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class WeatherData : ISubject
    {
        readonly List<string> _weatherDataKeys = new List<string>()
        {
            "currentTemp",
            "currentHumidity",
            "currentPressure",
            "tempForecast",
            "humidityForecast",
            "minTemp",
            "maxTemp",
            "averageTemp",
            "minHumidity",
            "maxHumidity",
            "averageHumidity",
            "minPressure",
            "maxPressure",
            "averagePressure",
            "pressureForecast",
            "maxHumidity",
            "humidity",
            "pressure",
        };

        List<IObserver> _observers = new List<IObserver>();

        Dictionary<string, int> _weatherDic = new Dictionary<string, int>();

        public int this [string key]
        {
            set
            {
                if(!_weatherDic.Any((pair) => pair.Key == key && pair.Value == value))
                {
                    _weatherDic[key] = value;
                    NotifyObservers();
                }
            }
        }

        public WeatherData()
        {
            MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            Random random = new Random();

            foreach (string key in _weatherDataKeys)
            {
                this[key] = random.Next(1, 100);
            }


        }

        public void NotifyObservers()
        {
            _observers.ForEach(observer => observer.Update(_weatherDic));
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
