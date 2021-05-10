using System;
using System.Collections.Generic;
using System.Text;

namespace Reporting.Models
{
    public class Report
    {
        public DateTime arrivalDate { set; get; }
        public DateTime departureDate { set; get; }
        public decimal price { set; get; }
        public string currency { set; get; }
        public string rateName { set; get; }
        public int adults { set; get; }
        public int breakfastIncluded { set; get; }
    }
}
