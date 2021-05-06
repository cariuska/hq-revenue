using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WebServiceAPI.Models;
using WebServiceAPI.Services;

namespace WebServiceAPITest 
{
    class HotelsRatesServicesFake : IHotelsRatesServices
    {

        List<HotelsRates> _hotelsRates;

        public HotelsRatesServicesFake()
        {
            _hotelsRates = new List<HotelsRates>()
            {
                new HotelsRates() {
                    hotel = new Hotel{
                        hotelID= 1
                    },
                    hotelRates = new List<HotelRates>()
                    {
                        new HotelRates()
                        {
                            targetDay = Convert.ToDateTime("2016-03-14T20:00:00-03:00")
                        },
                        new HotelRates()
                        {
                            targetDay = Convert.ToDateTime("2016-03-15T20:00:00-03:00")
                        }
                    }
                },
                new HotelsRates() {
                    hotel = new Hotel{
                        hotelID= 2
                    },
                    hotelRates = new List<HotelRates>()
                    {
                        new HotelRates()
                        {
                            targetDay = Convert.ToDateTime("2016-03-15T20:00:00-03:00")
                        },
                        new HotelRates()
                        {
                            targetDay = Convert.ToDateTime("2016-03-15T20:00:00-03:00")
                        }
                    }
                }
            };
        }

        public HotelsRates GetHotels(int HotelID, DateTime ArrivalDate)
        {
            HotelsRates hotelsRates = new HotelsRates();
            hotelsRates.hotelRates = new List<HotelRates>();

            HotelsRates hotels = new HotelsRates();

            hotels = _hotelsRates.Where(x => x.hotel.hotelID == HotelID).FirstOrDefault();

            if (hotels != null)
            {
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
