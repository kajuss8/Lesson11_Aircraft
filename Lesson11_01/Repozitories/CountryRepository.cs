using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Lesson11_01.Models;

namespace Lesson11_01.Repozitories
{
    internal class CountryRepository
    {

        public List<Country> Countries { get; set; }
        public CountryRepository()
        {
            Countries = new List<Country>();
            Countries.Add(new Country("LT", "lietuva", 1, true));
            Countries.Add(new Country("LV", "latvija", 2, true));
            Countries.Add(new Country("UK", "jungtine karalyste", 3, false));
        }
        public Country Retrieve(int id)
        {
            return Countries.Where(c => c.ID == id).FirstOrDefault();
        }
        public List<Country> Retrieve()
        {
            return Countries;
        }


    }
}
