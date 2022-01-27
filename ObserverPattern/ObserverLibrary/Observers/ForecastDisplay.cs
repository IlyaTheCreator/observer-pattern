using ObserverLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        /// <summary>
        /// In Celsius
        /// </summary>
        public int TempForecast { get; set; }
        /// <summary>
        /// In percentages
        /// </summary>
        public int HumidityForecast { get; set; }
        /// <summary>
        /// In millimeters of mercury
        /// </summary>
        public int PressureForecast { get; set; }

        public string Display()
        {
            return $"{GetType()}/Display: \n"
                + $"Прогноз температуры: {TempForecast}°C \n"
                + $"Прогноз влажности: {HumidityForecast}% \n"
                + $"Прогноз давления: {PressureForecast}мм рт \n";
        }

        public void Update(Dictionary<string, int> weatherDic)
        {
            TempForecast = weatherDic["tempForecast"];
            HumidityForecast = weatherDic["humidityForecast"];
            PressureForecast = weatherDic["pressureForecast"];
        }
    }
}
