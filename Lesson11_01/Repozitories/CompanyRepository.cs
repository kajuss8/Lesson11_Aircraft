using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11_01.Models;

namespace Lesson11_01.Repozitories
{
    internal class CompanyRepository
    {
        public List<Company> Companies { get; set; }
        public CompanyRepository()
        {
            Companies = new List<Company>();
            Companies.Add(new Company("galaxy", 1, 10));
            Companies.Add(new Company("riley", 2, 11));
            Companies.Add(new Company("bambuza", 3, 12));
        }
        public Company Retrieve(int id)
        {
            return Companies.Where(c => c.ID == id).FirstOrDefault();
        }
        public List<Company> Retrieve()
        {
            return Companies;
        }


    }
}
