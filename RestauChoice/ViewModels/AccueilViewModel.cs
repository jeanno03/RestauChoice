using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauChoice.ViewModels
{
    public class AccueilViewModel
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public Models.Restaurant Resto { get; set; }
        public List<Models.Restaurant> ListeDesRestos { get; set; }
    }
}