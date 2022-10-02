using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class ReportItem
    {
        public int PlaneTailNumber { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public string CompanyName { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public ReportItem()
        {

        }
        public ReportItem(int plainTailNumber, int number, string description, string companyName, string countryCode, string countryName)
        {
            PlaneTailNumber = plainTailNumber;
            Number = number;
            Description = description;
            CompanyName = companyName;
            CountryCode = countryCode;
            CountryName = countryName;
        }
    }
}
