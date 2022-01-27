using ObserverLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        /// <summary>
        /// In Celsius
        /// </summary>
        public int CurrentTemp { get; set; }
        /// <summary>
        /// In percentages
        /// </summary>
        public int CurrentHumidity { get; set; }
        /// <summary>
        /// In millimeters of mercury
        /// </summary>
        public int CurrentPressure { get; set; }

        public string Display()
        {
            return $"{GetType()}/Display: \n"
                + $"Настоящая температура: {CurrentTemp}°C \n"
                + $"Настоящая влажность: {CurrentHumidity}% \n"
                + $"Настоящее давление: {CurrentPressure}мм рт \n";
        }

        public void Update(Dictionary<string, int> weatherDic)
        {
            CurrentTemp = weatherDic["currentTemp"];
            CurrentHumidity = weatherDic["humidity"];
            CurrentPressure = weatherDic["pressure"];
        }
    }
}
