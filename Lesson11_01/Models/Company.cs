using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class Company
    {
        public string OwnerCompanyName { get; set; }
        public int ID { get; set; }
        public int CountryId { get; set; }

        public Company(string ownerCompanyName, int id, int countryId)
        {
            OwnerCompanyName = ownerCompanyName;
            ID = id;
            CountryId = countryId;
        }
    }
}
