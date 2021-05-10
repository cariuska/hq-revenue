using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporting.Models
{
    public class Price
    {
        public string currency { get; set; }
        public decimal numericFloat { get; set; }
        public int numericInteger { get; set; }
    }
}
