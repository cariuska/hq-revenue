using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporting.Models
{
    public class HotelsRates
    {
        public Hotel hotel { get; set; }
        public List<HotelRates> hotelRates { get; set; }
    }
}
