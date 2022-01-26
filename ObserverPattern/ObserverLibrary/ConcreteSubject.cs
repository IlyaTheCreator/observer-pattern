using ObserverLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class ConcreteSubject : ISubject
    {
        private string _state;
        List<IObserver> _observers = new List<IObserver>();
        public string NotificationOutput { get; set; }

        public string State {
            get => _state;
            set
            {
                _state = value;
                NotificationOutput = NotifyObservers();
            }
        }

        public string NotifyObservers()
        {
            string output = "";

            _observers.ForEach(observer => output += $"{observer.Update()} \n");

            return output;
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
