using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.ObjectPool
{
    class ObjectPool<T>
    {
        private ConcurrentQueue<T> _queue;

        public ObjectPool(int count, Func<T> create)
        {
            _queue = new ConcurrentQueue<T>( Enumerable.Range(1, count).Select(x => create()) );
        }

        public T Acquire()
        {
            if (_queue.TryDequeue(out var obj))
                return obj;
            return default;
        }

        public void Release(T obj)
        {
            _queue.Enqueue(obj);
        }

    }
}
