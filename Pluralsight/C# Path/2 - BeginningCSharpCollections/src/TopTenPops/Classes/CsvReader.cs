using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace TopTenPops.Classes
{
    class CsvReader
    {
        // CSV = Comma Separated Values
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public Country[] ReadFirstNCountries(int nCountries)
        {
            // We have to use SQUARE Brackets [] to initialize an array.
            Country[] countries = new Country[nCountries];

            if(File.Exists(_csvFilePath))
            {
                countries = File.ReadAllLines(_csvFilePath)
                                .Skip(1)
                                .Take(nCountries)
                                .Select(ReadCountryFromCsvLine)                                
                                .ToArray();
            }

            return countries;
        }

        public List<Country> ReadAllCountries()
        {
            var countries = new List<Country>();

            using(StreamReader sr = new StreamReader(_csvFilePath))
            {
                // read header line
                sr.ReadLine();

                string csvLine = string.Empty;

                while((csvLine = sr.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(csvLine));
                }
            }

            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            string name = string.Empty;
            string code = string.Empty;
            string region = string.Empty;
            string populationTxt = string.Empty;           

            switch(parts.Length)
            {
                case 4:
                    name = parts[0];
                    code = parts[1];
                    region = parts[2];
                    populationTxt = parts[3];
                    break;

                case 5:
                    name = parts[0] + ", " + parts[1];
                    name = name.Replace("\"", null).Trim();
                    code = parts[2];
                    region = parts[3];
                    populationTxt = parts[4];
                    break;

                default:
                    throw new ArgumentException($"Can't parse country from csvLine: {csvLine}");
            }

            // TryParse leaves population = 0 if it can't parse.
            int.TryParse(populationTxt, out int population);
            return new Country(name, code, region, population);
        }
    }
}