using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Reporting.Models;

namespace Reporting.Services
{
    public class HotelsRatesServices
    {
        HotelsRates _hotelsRates;

        public HotelsRatesServices()
        {
            using (StreamReader r = new StreamReader("Data/hotelrates.json"))
            {
                string json = r.ReadToEnd();
                _hotelsRates = JsonConvert.DeserializeObject<HotelsRates>(json);
            }
        }

        public HotelsRates GetHotels()
        {
            return _hotelsRates;
        }        

    }
}
