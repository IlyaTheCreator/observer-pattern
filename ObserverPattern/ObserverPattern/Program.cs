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

            cSubject.State = "new state";

            Console.WriteLine(cObserver1.NumberOfUpdates);
            Console.WriteLine(cObserver2.NumberOfUpdates);

            Console.WriteLine();

            cSubject.RegisterObserver(cObserver2);

            cSubject.State = "yet another state";

            Console.WriteLine(cObserver1.NumberOfUpdates);
            Console.WriteLine(cObserver2.NumberOfUpdates);

            Console.WriteLine();

            cSubject.RemoveObserver(cObserver2);

            cSubject.State = "state changed again";

            Console.WriteLine(cObserver1.NumberOfUpdates);
            Console.WriteLine(cObserver2.NumberOfUpdates);

            Console.ReadKey();
        }
    }
}
