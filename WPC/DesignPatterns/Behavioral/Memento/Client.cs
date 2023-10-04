using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Memento
{
    class Client
    {
        public static void Execute()
        {
            var person = new Person();
            //var caretaker = new Caretaker<Person>(person);
            var autoCaretaker = new AutoCaretaker<Person>(person);
            Thread.Sleep(1500);

            person.FirstName = "Ewa";
            person.LastName = "Ewowska";
            Console.WriteLine(person);
            //caretaker.SaveState();
            Thread.Sleep(1500);

            person.FirstName = "Monika";
            Console.WriteLine(person);
            //caretaker.SaveState();
            Thread.Sleep(1500);

            person.LastName = "Monikowska";
            Console.WriteLine(person);
            //caretaker.SaveState();
            Thread.Sleep(1500);

            person.LastName = null;
            Console.WriteLine(person);

            //caretaker.RestoreState();
            autoCaretaker.RestoreState();
            Console.WriteLine(person);

            /*caretaker.RestoreState();
            Console.WriteLine(person);
            caretaker.RestoreState();
            Console.WriteLine(person);*/

            //caretaker.RestoreState(DateTime.Now.AddSeconds(-3));
            autoCaretaker.RestoreState(DateTime.Now.AddSeconds(-3));
            Console.WriteLine(person);
        }
    }
}
