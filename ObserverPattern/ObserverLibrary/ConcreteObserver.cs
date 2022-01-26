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
        private int _numberOfUpdates;

        public int NumberOfUpdates
        {
            get => _numberOfUpdates;
        }

        public void Update()
        {
            _numberOfUpdates++;
        }
    }
}
