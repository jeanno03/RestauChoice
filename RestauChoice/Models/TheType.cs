using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauChoice.Models
{
    public class TheType
    {
        public int TheTypeId  { get; set; }
        public string Nom  { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }

        public TheType()
        {
            this.Restaurants = new HashSet<Restaurant>();
        }

        public TheType(string nom)
        {
            Nom = nom;
        }
    }
}