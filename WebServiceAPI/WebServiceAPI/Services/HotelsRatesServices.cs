using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebServiceAPI.Models;

namespace WebServiceAPI.Services
{
    public class HotelsRatesServices : IHotelsRatesServices
    {
        List<HotelsRates> _hotelsRates;

        public HotelsRatesServices()
        {
            using (StreamReader r = new StreamReader("data/hotelsrates.json"))
            {
                string json = r.ReadToEnd();
                _hotelsRates = JsonConvert.DeserializeObject<List<HotelsRates>>(json);
            }
        }

        public HotelsRates GetHotels(int HotelID, DateTime ArrivalDate)
        {

            HotelsRates hotelsRates = new HotelsRates();
            hotelsRates.hotelRates = new List<HotelRates>();

            HotelsRates hotels = new HotelsRates();

            hotels = _hotelsRates.Where(x => x.hotel.hotelID == HotelID).FirstOrDefault();

            if (hotels != null) {
                hotelsRates.hotel = hotels.hotel;

                if (ArrivalDate != new DateTime())
                {
                    foreach (HotelRates hotelRates in hotels.hotelRates)
                    {
                        if (hotelRates.targetDay == ArrivalDate)
                        {
                            hotelsRates.hotelRates.Add(hotelRates);
                        }
                    }
                }
                else
                {
                    hotelsRates.hotelRates = hotels.hotelRates;
                }
            }

            return hotelsRates;
        }
        

    }
}
