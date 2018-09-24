using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauChoice.Models
{
    public class Type
    {
        public int TypeId  { get; set; }
        public string Nom  { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }

        public Type()
        {
            this.Restaurants = new HashSet<Restaurant>();
        }

        public Type(string nom)
        {
            Nom = nom;
        }
    }
}