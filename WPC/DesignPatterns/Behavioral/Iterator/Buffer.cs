using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Iterator
{
    class Buffer<T> : IEnumerable<Tuple<T, T>>
    {
        private IEnumerable<T> _collection;

        public Buffer(IEnumerable<T> collection)
        {
            _collection = collection;
        }

        public IEnumerator<Tuple<T, T>> GetEnumerator()
        {
            return new BufferIterator<T>(_collection.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
