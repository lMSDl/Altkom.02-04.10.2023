using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Iterator
{
    class BufferIterator<T> : IEnumerator<Tuple<T, T>>
    {
        private readonly IEnumerator<T> _enumerator;

        public BufferIterator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
            Reset();
        }

        public Tuple<T, T> Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _enumerator.Dispose();
            Current = default;
        }

        public bool MoveNext()
        {
            if (_enumerator.MoveNext())
            {
                Current = new Tuple<T, T>(Current.Item2, _enumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            if(_enumerator.MoveNext())
            {
                Current = new Tuple<T, T>(default, _enumerator.Current);
            }
            else
            {
                Current = default;
            }
        }
    }
}
