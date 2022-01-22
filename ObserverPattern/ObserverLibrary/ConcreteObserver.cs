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
        public void Update()
        {
            Output($"{GetType()} - UPDATED!");
        }

        // remove later 
        private void Output(string text)
        {
            Console.WriteLine(text);
        }
    }
}
