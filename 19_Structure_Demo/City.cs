using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Structure_Demo
{
    struct City : IComparable, IComparable<City>
    {
        const int DefaultPopulation = 100_000;
        const int MaxPopulation = 10_000_000;

        private int population;
        public string Name { get; set; } //= "NoName";
        public int Population { 
            get=>population; 
            set => population = value <=MaxPopulation ? value : MaxPopulation; }
        public City(string name, int population = DefaultPopulation)
        {
            Name = name;
            Population = population;
        }
        public override string ToString()
        {
            return $"Name :: {Name,-10} Population :: {Population,-15}";
        }

        public int CompareTo(object? obj)
        {
            Console.WriteLine("CompareTo<>");
            if(!(obj is City)) // not City 
            {
                throw new ArgumentException("CompareTo() : object is not City");
            }
            City city = (City)obj; // unboxing
            return this.population.CompareTo(city.population);
        }

        public int CompareTo(City other)
        {
            Console.WriteLine("CompareTo<City>");
            return this.population.CompareTo(other.population);
        }
    }

    struct ComparerByName : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    struct CompareByNameDesc : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return -x.Name.CompareTo(y.Name);
        }
    }
}
