using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauChoice.Models
{
    public class Evenement
    {
        public int EvenementId { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public virtual TheUser TheUser { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }

        public Evenement()
        {
            this.Votes = new HashSet<Vote>();
            this.Comments = new HashSet<Comment>();
            this.Restaurants = new HashSet<Restaurant>();
        }

        public Evenement(string nom, string description)
        {
            Nom = nom;
            Description = description;
        }
    }
}