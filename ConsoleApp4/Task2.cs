using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Task2
    {
        public static void PrintAllCities(string[] cities)
        {
            var allCities = from city in cities
                            select city;

            Console.WriteLine("Всі міста:");
            foreach (var city in allCities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
        }

        public static void PrintCitiesWithLength(string[] cities, int length)
        {
            var citiesWithLength = from city in cities
                                   where city.Length == length
                                   select city;

            Console.WriteLine($"Міста з довжиною назви {length}:");
            foreach (var city in citiesWithLength)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
        }

        public static void PrintCitiesStartingWithA(string[] cities)
        {
            var citiesStartingWithA = from city in cities
                                      where city.StartsWith('A')
                                      select city;

            Console.WriteLine("Міста які починаються з літери A:");
            foreach (var city in citiesStartingWithA)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
        }

        public static void PrintCitiesEndingWithM(string[] cities)
        {
            var citiesEndingWithM = from city in cities
                                    where city.EndsWith('m')
                                    select city;

            Console.WriteLine("Міста які закінчуються на M:");
            foreach (var city in citiesEndingWithM)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
        }

        public static void PrintCitiesNK(string[] cities)
        {
            var citiesStartingWithNEndingWithK = from city in cities
                                                 where city.StartsWith('N') && city.EndsWith('k')
                                                 select city;

            Console.WriteLine("Міста які починаються на N і закінчуються на k:");
            foreach (var city in citiesStartingWithNEndingWithK)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
        }
    }
}
