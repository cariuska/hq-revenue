using System;
using WebServiceAPI.Models;

namespace WebServiceAPI.Services
{
    public interface IHotelsRatesServices
    {
        HotelsRates GetHotels(int HotelID, DateTime ArrivalDate);
    }
}
