using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RestauChoice.Models;

namespace RestauChoice.ViewModels
{
    public class AccueilViewModel
    {
      //  internal TheUser theUser;

        public string Message { get; set; }
        [Display(Name ="La super date")]
        public DateTime Date { get; set; }
        public Models.Restaurant Resto { get; set; }
        public List<Models.Restaurant> ListeDesRestos { get; set; }
        public Models.Visitor Visitor { get; set; }
        public Models.TheUser TheUsers { get; set; }
    }
}