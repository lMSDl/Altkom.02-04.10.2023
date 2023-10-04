using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Observer
{
    class Publisher : IObservable<int>, IDisposable
    {
        private List<IObserver<int>> _observers = new List<IObserver<int>>();
        private int index;

        public int Index
        {
            get => index;
            set
            {
                index = value;
                Notify();
            }
        }

        public async Task Work()
        {
            for (int i = 0; i < 15; i++)
            {
                await Task.Delay(1000);
                var second = DateTime.Now.Second;
                if (second % 3 == 0)
                {
                    Index = second;
                }
            }
        }

        public void Notify()
        {
            Console.WriteLine($"Powiadomienie: {Index}");
            if (Index == 0)
            {
                foreach (var observer in _observers.ToList())
                {
                    observer.OnError(new IndexOutOfRangeException(Index.ToString()));
                }
            }
            else
            {
                foreach (var observer in _observers.ToList())
                {
                    observer.OnNext(Index);
                }
            }
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            Console.WriteLine($"{observer.GetType().Name} wspisał się na listę subskrypcji");
            return new Subscription(() => {
                _observers.Remove(observer);
                Console.WriteLine($"{observer.GetType().Name} wypisał się z subskrypcji");
            });
        }

        public void Dispose()
        {
            _observers.ToList().ForEach(x => x.OnCompleted());
        }
    }
}
