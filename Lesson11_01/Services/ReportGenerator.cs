

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11_01.HTML;
using Lesson11_01.Models;
using Lesson11_01.Repozitories;

namespace Lesson11_01.services
{
    internal class ReportGenerator
    {
        AircraftRepository aircraftRepository;
        AircraftModelRepository aircraftModelRepository;
        CompanyRepository companyRepository;
        CountryRepository countryRepository;

        public ReportGenerator(AircraftRepository aircraftRepository, AircraftModelRepository aircraftModelRepository, CompanyRepository companyRepository, CountryRepository countryRepository)
        {
            this.aircraftRepository = aircraftRepository;
            this.aircraftModelRepository = aircraftModelRepository;
            this.companyRepository = companyRepository;
            this.countryRepository = countryRepository;
        }

        public List<ReportItem> GenerateReportAircraftEurope()
        {
            List<Aircraft> allAircraft = aircraftRepository.Retrieve();
            List<ReportItem> isFromEurope = new List<ReportItem>();
            foreach (var plane in allAircraft)
            {


                if (countryRepository.Retrieve(plane.ID).IsTheCountryInEurope == true)
                {
                    ReportItem ataskaitosVienetas = new ReportItem();
                    ataskaitosVienetas.PlaneTailNumber = plane.TailNumber;
                    ataskaitosVienetas.Number = aircraftModelRepository.Retrieve(plane.ID).ModelNumber;
                    ataskaitosVienetas.Description = aircraftModelRepository.Retrieve(plane.ID).ModelDescription;
                    ataskaitosVienetas.CompanyName = companyRepository.Retrieve(plane.ID).OwnerCompanyName;
                    ataskaitosVienetas.CountryCode = countryRepository.Retrieve(plane.ID).CountryCode;
                    ataskaitosVienetas.CountryName = countryRepository.Retrieve(plane.ID).CountryName;
                    isFromEurope.Add(ataskaitosVienetas);

                }
                
            }
            
            return isFromEurope;
        }

        public List<ReportItem> GenerateReportAircraftNotEurope()
        {
            List<Aircraft> allAircraft = aircraftRepository.Retrieve();
            List<ReportItem> isNotFromEurope = new List<ReportItem>();

            foreach (var plane in allAircraft)
            {


                if (countryRepository.Retrieve(plane.ID).IsTheCountryInEurope == false)
                {
                    ReportItem ataskaitosVienetas = new ReportItem();
                    ataskaitosVienetas.PlaneTailNumber = plane.TailNumber;
                    ataskaitosVienetas.Number = aircraftModelRepository.Retrieve(plane.ID).ModelNumber;
                    ataskaitosVienetas.Description = aircraftModelRepository.Retrieve(plane.ID).ModelDescription;
                    ataskaitosVienetas.CompanyName = companyRepository.Retrieve(plane.ID).OwnerCompanyName;
                    ataskaitosVienetas.CountryCode = countryRepository.Retrieve(plane.ID).CountryCode;
                    ataskaitosVienetas.CountryName = countryRepository.Retrieve(plane.ID).CountryName;
                    isNotFromEurope.Add(ataskaitosVienetas);

                }

            }

            return isNotFromEurope;
        }


    }
}
