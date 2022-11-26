using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();

            address.Country = "Украина";
            address.City = "Одесса";
            address.Street = "Раскидайловская";
            address.Index = "34568";
            address.Apartment = "54";
            address.House = "4";

            Console.WriteLine($"{address.Country}, {address.City} {address.Index}, {address.Street} {address.House} кв. {address.Apartment}");
            Console.ReadKey();
        }
    }
}
