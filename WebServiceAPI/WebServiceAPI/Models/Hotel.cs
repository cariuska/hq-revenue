using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceAPI.Models
{
    public class Hotel
    {
      public int classification { get; set; }
      public int hotelID { get; set; }
      public string name{ get; set; }
      public decimal reviewscore { get; set; }
    }
}
