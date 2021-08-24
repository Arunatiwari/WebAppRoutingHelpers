using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRoutingHelpers.Models
{
    public class City
    {
        public City()
        {
            CityList = new List<Itemlist>()
            {
                new Itemlist {Text="Bangalore", Value=1,countryID=1},
                new Itemlist {Text="Delhi", Value=2,countryID=1},
                new Itemlist {Text="New York", Value=3,countryID=2},
                new Itemlist {Text="Los Angeles", Value=4,countryID=2},
            };
        }
        public List<Itemlist> CityList { get; set; }
        //public string CityName { get; set; }
        //public int CityId { get; set; }
    }
}
