using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauChoice.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        [Required(ErrorMessage = "Le Nom est obligatoire")]
        [Display(Name = "Nom du restaurant")]
        public string Nom { get; set; }
        [Display(Name = "Super Adresse")]
        public string Adresse { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
        public virtual ICollection<Evenement> Evenements { get; set; }
        public virtual TheType TheType { get; set; }

        public Restaurant()
        {
            this.Votes = new HashSet<Vote>();
            this.Evenements = new HashSet<Evenement>();
        }

        public Restaurant(string nom, string adresse)
        {
            Nom = nom;
            Adresse = adresse;
        }
    }
}