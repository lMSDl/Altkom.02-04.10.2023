using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Structural.Proxy
{
    class DatabaseProxy : IDatabase
    {
        private IDatabase database;
        private Func<IDatabase> _openDatabase;
        private const int InitialCount = 3;
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(InitialCount);

        public DatabaseProxy(IDatabase database)
        {
            this.database = database;
        }
        public DatabaseProxy(IDatabase database, Func<IDatabase> openDatabase) : this(database)
        {
            _openDatabase = openDatabase;
        }

        public async Task<int?> RequestAsync(int parameter)
        {
            if (_openDatabase != null && database == null)
            {
                Console.WriteLine("Łączymy się z bazą danych");
                database = _openDatabase();
            }

            await semaphore.WaitAsync();

            var result = await database.RequestAsync(parameter);

            semaphore.Release();
            if (_openDatabase != null && semaphore.CurrentCount == InitialCount)
            {
                Console.WriteLine("Zamykamy bazę danych");
                database = null;
            }

            return result;
        }
    }
}
