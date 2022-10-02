using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace Lesson11_01.Models
{
    internal class Aircraft
    {
        public int TailNumber { get; set; }
        public int ID { get; set; }
        public int CountryId { get; set; }
        public int CompanyId { get; set; }

        public Aircraft(int tailNumber, int id, int countryId, int ComapanyId)
        {
            TailNumber = tailNumber;
            ID = id;
            CountryId = countryId;
            CompanyId = ComapanyId;
        }

    }
}
