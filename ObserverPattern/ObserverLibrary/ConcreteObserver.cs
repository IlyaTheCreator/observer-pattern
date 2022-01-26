using ObserverLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary
{
    public class ConcreteObserver : IObserver
    {
        public string Update()
        {
            return $"{GetType()} - UPDATED!";
        }
    }
}
