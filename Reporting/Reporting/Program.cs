using System;
using System.Collections.Generic;
using Reporting.Services;
using Reporting.Models;

namespace Reporting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exporting Data!");

            HotelsRatesServices hotelsRatesServices = new HotelsRatesServices();
            ExcelGenerate excelGenerate = new ExcelGenerate();

            List<Report> reports = new List<Report>();

            HotelsRates hotelsRates = hotelsRatesServices.GetHotels();

            foreach (HotelRates item in hotelsRates.hotelRates)
            {
                DateTime arrivalDate = item.targetDay;
                DateTime departureDate = item.targetDay.AddDays(item.los);
                decimal price = item.price.numericFloat;
                string currency = item.price.currency;
                string rateName = item.rateName;
                int adults = item.adults;
                int breakfastIncluded = item.rateTags.Find(x => x.name == "breakfast").shape == true ? 1 : 0 ;

                reports.Add(new Report
                {
                    arrivalDate = arrivalDate,
                    departureDate = departureDate,
                    price = price,
                    currency = currency,
                    rateName = rateName,
                    adults = adults,
                    breakfastIncluded = breakfastIncluded

                });
            }

            excelGenerate.Generate(reports);

            Console.WriteLine("Export Finished!");
        }
    }
}
