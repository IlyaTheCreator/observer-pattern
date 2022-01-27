using ObserverLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.Observers
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        // In Celsius
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public int AverageTemp { get; set; }

        // In percentages
        public int MinHumidity { get; set; }
        public int MaxHumidity { get; set; }
        public int AverageHumidity { get; set; }

        // In millimeters of mercury
        public int MinPressure { get; set; }
        public int MaxPressure { get; set; }
        public int AveragePressure { get; set; }

        public string Display()
        {
            return $"{GetType()}/Display: \n"
                + $"Минимальная температура: {MinTemp}°C \n"
                + $"Максималная температура: {MaxTemp}°C \n"
                + $"Средняя температура: {AverageTemp}°C \n"
                + $"Минимальная влажность: {MaxHumidity}% \n"
                + $"Максималная влажность: {MinHumidity}% \n"
                + $"Средняя влажность: {AverageHumidity}% \n"
                + $"Минимальное давление: {MinPressure}мм рт \n"
                + $"Максимално давление: {MaxPressure}мм рт \n"
                + $"Среднее давление: {AveragePressure}мм рт \n";
        }

        public void Update(Dictionary<string, int> weatherDic)
        {
            AverageTemp = weatherDic["averageTemp"];
            AverageHumidity = weatherDic["averageHumidity"];
            AveragePressure = weatherDic["averagePressure"];
            MinTemp = weatherDic["minTemp"];
            MinHumidity = weatherDic["minHumidity"];
            MinPressure = weatherDic["minPressure"];
            MaxTemp = weatherDic["maxTemp"];
            MaxHumidity = weatherDic["maxHumidity"];
            MaxPressure = weatherDic["maxPressure"];
        }
    }
}
