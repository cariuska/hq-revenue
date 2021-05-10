using System;
using System.Collections.Generic;
using System.Text;
using Reporting.Models;
using SwiftExcel;

namespace Reporting.Services
{
    public class ExcelGenerate
    {
        public ExcelGenerate()
        {
        }

        public void Generate(List<Report> reports)
        {
            using (var ew = new ExcelWriter("report.xlsx"))
            {
                int row = 1;

                ew.Write("ARRIVAL_DATE", 1, row);
                ew.Write("DEPARTURE_DATE", 2, row);
                ew.Write("PRICE", 3, row);
                ew.Write("CURRENCY", 4, row);
                ew.Write("RATENAME", 5, row);
                ew.Write("ADULTS", 6, row);
                ew.Write("BREAKFAST_INCLUDED", 7, row);

                foreach (Report item in reports)
                {
                    row++;

                    ew.Write(item.arrivalDate.ToString("dd.MM.yy"), 1, row);
                    ew.Write(item.departureDate.ToString("dd.MM.yy"), 2, row);
                    ew.Write(item.price.ToString("N2"), 3, row);
                    ew.Write(item.currency, 4, row);
                    ew.Write(item.rateName, 5, row);
                    ew.Write(item.adults.ToString(), 6, row);
                    ew.Write(item.breakfastIncluded.ToString(), 7, row);
                }
            }

        }


    }
}
