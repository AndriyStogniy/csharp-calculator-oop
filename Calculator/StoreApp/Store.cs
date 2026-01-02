using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp
{
    public class Store: IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public StoreType Type { get; set; }

        private bool disposed = false;

        public Store(string name, string address, StoreType type)
        {
            Name = name;
            Address = address;
            Type = type;

            Console.WriteLine("Store object created.");
        }

        public void ShowInfo()
        {
            if (disposed)
                throw new ObjectDisposedException(nameof(Store));

            Console.WriteLine("Store information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine();
        }


        public void Dispose()
        {
            if (disposed)
                return;

            Console.WriteLine($"Store disposed.");

            disposed = true;
        }

        // Деструктор
        ~Store()
        {
            Console.WriteLine($"Destructor called for store \"{Name}\".");
        }
    }
}
