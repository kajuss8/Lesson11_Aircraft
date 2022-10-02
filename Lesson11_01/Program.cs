using Lesson11_01.HTML;
using Lesson11_01.Repozitories;
using Lesson11_01.services;
using System;
using System.Collections.Generic;

AircraftRepository aircraftRepository = new AircraftRepository();
AircraftModelRepository aircraftModelRepository = new AircraftModelRepository();
CompanyRepository companyRepository = new CompanyRepository();
CountryRepository countryRepository = new CountryRepository();

ReportGenerator reportGenerator = new ReportGenerator(aircraftRepository, aircraftModelRepository, companyRepository, countryRepository);
HtmlProject htmlProject = new HtmlProject(reportGenerator.GenerateReportAircraftEurope().ToString());

string galutineAtaskaita = "<html><body>";
int temp = 0;
foreach (var item in reportGenerator.GenerateReportAircraftEurope())
{
    temp++;
    Console.WriteLine($"Aircraft tail number: {item.PlaneTailNumber}\nAircraft model number: {item.Number}\nAircraft model description: {item.Description}\n" +
        $"Owner company name: {item.CompanyName}\nCompany country code: {item.CountryCode}\nCompany country name: {item.CountryName}\n");
    

    galutineAtaskaita = galutineAtaskaita
        + "<p> Nr: " + temp  + " plane</p>"
        + "<p style=\"background-color:powderblue;\"> Aircraft tail number: " + item.PlaneTailNumber + "</p>"
        + "<p style=\"background-color:powderblue;\">Aircraft model number: " + item.Number + "</p>"
        + "<p style=\"background-color:powderblue;\">Aircraft model description: " + item.Description + "</p>"
        + "<p style=\"background-color:powderblue;\">Owner company name: " + item.CompanyName + "</p>"
        + "<p style=\"background-color:powderblue;\">Company country code: " + item.CountryCode + "</p>"
        + "<p style=\"background-color:powderblue;\">Company country name: " + item.CountryName + "</p>";


    
}
foreach (var item in reportGenerator.GenerateReportAircraftNotEurope())
{
    temp++;
    galutineAtaskaita = galutineAtaskaita
        + "<p> Nr: " + temp + " plane</p>"
        + "<p style=\"background-color:red;\">Aircraft tail number: " + item.PlaneTailNumber + "</p>"
        + "<p style=\"background-color:red;\">Aircraft model number: " + item.Number + "</p>"
        + "<p style=\"background-color:red;\">Aircraft model description: " + item.Description + "</p>"
        + "<p style=\"background-color:red;\">Owner company name: " + item.CompanyName + "</p>"
        + "<p style=\"background-color:red;\">Company country code: " + item.CountryCode + "</p>"
        + "<p style=\"background-color:red;\">Company country name: " + item.CountryName + "</p>";

}    


htmlProject.Generator(galutineAtaskaita);

