using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp
{
    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        // +
        public static City operator + (City city, int amount)
        {
            return new City(city.Name, city.Population + amount);
        }
        
        
        // -
        public static City operator -(City city, int amount)
        {
            return new City(city.Name, city.Population - amount);
        }

        // ==
        public static bool operator ==(City a, City b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Population == b.Population;
        }

        // !=
        public static bool operator !=(City a, City b)
        {
            return !(a == b);
        }

        // <
        public static bool operator <(City a, City b)
        {
            return a.Population < b.Population;
        }

        // >
        public static bool operator >(City a, City b)
        {
            return a.Population > b.Population;
        }

        public override bool Equals(object obj)
        {
            if (obj is City other)
                return Population == other.Population;
            return false;
        }

        public override int GetHashCode()
        {
            return Population.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Name} — Population: {Population}";
        }
    }
}

