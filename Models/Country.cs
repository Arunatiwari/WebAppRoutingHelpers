using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRoutingHelpers.Models
{
    public class Country
    {
        public Country()
        {
            CountryList = new List<Itemlist>()
            {
                new Itemlist {Text="India", Value=1},
                new Itemlist {Text="USA", Value=2},
            };
        }
        public List<Itemlist> CountryList { get; set; }
        //public string CountryName { get; set; }
        //public int CountryId { get; set; }
        //public virtual Country country {get;set;}
    }
}
