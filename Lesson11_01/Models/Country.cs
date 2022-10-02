using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class Country
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public int ID { get; set; }
        public bool IsTheCountryInEurope { get; set; }

        public Country(string countryCode, string countryName, int id, bool isTheCountryInEurope)
        {
            CountryCode = countryCode;
            CountryName = countryName;
            ID = id;
            IsTheCountryInEurope = isTheCountryInEurope;
        }


    }
}
