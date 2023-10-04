using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.Command
{
    class Garden
    {
        public int Size { get; }
        private List<string> Plants { get; } = new List<string>();

        public Garden(int size)
        {
            Size = size;
        }

        public bool Add(string name)
        {
            if (Plants.Count < Size)
            {
                Plants.Add(name);
                Console.WriteLine($"Roślina {name} zasadzona w ogrodzie");
                return true;
            }
            Console.WriteLine($"Brak miejsca na {name}");
            return false;
        }

        public bool Remove(string name)
        {
            var result = Plants.Remove(name);
            if (result)
                Console.WriteLine($"Roślina {name} usunięta z ogrodu");
            else
                Console.WriteLine($"W ogrodznie nie ma {name}");
            return result;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"W ogrodznie jest {Plants.Count} roślin:");
            foreach (var name in Plants)
            {
                builder.AppendLine(name);
            }
            return builder.ToString();
        }
    }
}
