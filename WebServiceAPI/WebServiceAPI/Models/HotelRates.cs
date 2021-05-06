using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceAPI.Models
{
    public class HotelRates
    {
        public int adults { get; set; }
        public int los { get; set; }
        public Price price { get; set; }
        public string rateDescription { get; set; }
        public string rateID { get; set; }
        public string rateName { get; set; }
        public List<RateTags> rateTags { get; set; }
        public DateTime targetDay { get; set; }
    }
}
