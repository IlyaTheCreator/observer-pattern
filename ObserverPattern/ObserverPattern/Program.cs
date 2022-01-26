using ObserverLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConcreteSubject cSubject = new ConcreteSubject() { State = "bruh" };
            ConcreteObserver cObserver1 = new ConcreteObserver();
            ConcreteObserver cObserver2 = new ConcreteObserver();

            cSubject.RegisterObserver(cObserver1);
            cSubject.RegisterObserver(cObserver2);

            cSubject.State = "new state";
            Console.WriteLine(cSubject.NotificationOutput);

            cSubject.RemoveObserver(cObserver2);

            cSubject.State = "yet another state";
            Console.WriteLine(cSubject.NotificationOutput);

            Console.ReadKey();
        }
    }
}
