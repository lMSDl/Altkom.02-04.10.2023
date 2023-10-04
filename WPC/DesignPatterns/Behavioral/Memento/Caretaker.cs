using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Memento
{
    class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private ICollection<Memento<T>> _mementos = new List<Memento<T>>();
        protected T originator;

        public Caretaker(T originator)
        {
            this.originator = originator;
            SaveState();
        }

        public void SaveState()
        {
            var memento = new Memento<T>(originator);
            _mementos.Add(memento);
            Console.WriteLine($"Caretaker: snapshot {memento.DateTime}");
        }

        public void RestoreState()
        {
            var memento = _mementos.LastOrDefault();
            if(memento != null)
            {
                _mementos.Remove(memento);
                RestoreState(memento);
            }
        }

        public void RestoreState(DateTime dateTime)
        {
            var memento = _mementos.LastOrDefault(x => x.DateTime <= dateTime);
            if (memento != null)
            {
                RestoreState(memento);
            }
        }

        protected virtual void RestoreState(Memento<T> memento)
        {
            originator.Restore(memento.GetState());
            Console.WriteLine($"Caretaker: restored {memento.DateTime}");
        }
    }
}
