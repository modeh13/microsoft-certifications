using System;
using System.IO;
using System.Collections.Generic;
using TopTenPops.Classes;

namespace TopTenPops
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine("Files", "Pop.csv");
            var csvReader = new CsvReader(filePath);

            // Print first 10 elements
            Country[] countries = csvReader.ReadFirstNCountries(10);
            PrintCountries(countries);

            List<Country> allCountries = csvReader.ReadAllCountries();

            // Inserting elements
            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);            
            int liliputIndex = allCountries.FindIndex(x => x.Population < 2_000_000);            
            allCountries.Insert(liliputIndex, lilliput);

            // Removing elements
            allCountries.RemoveAt(liliputIndex);
            PrintCountries(allCountries);

            // Working with Dictionaries
            Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            Country finland = new Country("Finland", "FIN", "Europe", 5_511_303);

            var countriesDictionary = new Dictionary<string, Country>
            {
                { norway.Code, norway },
                { finland.Code, finland }
            };

            // It will check if key exists in Dictionary, if so returns true, otherwise false
            // but if element is found, second parameter will be VALUE.
            bool exists = countriesDictionary.TryGetValue("MUS", out Country musCountry);

            foreach(var country in countriesDictionary.Values)
                Console.WriteLine(country.Name);            
        }

        private static void PrintCountries(IEnumerable<Country> countries)
        {
            foreach(var country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}