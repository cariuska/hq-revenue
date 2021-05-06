using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceAPI.Models;
using WebServiceAPI.Services;

namespace WebServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelsRatesController : ControllerBase
    {
        private readonly IHotelsRatesServices _hotelsRatesServices;

        public HotelsRatesController(IHotelsRatesServices hotelsRatesServices)
        {
            _hotelsRatesServices = hotelsRatesServices;
        }


        [HttpGet]
        public HotelsRates Get(int HotelID, DateTime ArrivalDate)
        {
            return _hotelsRatesServices.GetHotels(HotelID, ArrivalDate);
        }
    }
}
