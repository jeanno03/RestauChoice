using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RestauChoice.Models
{
    public class Visitor
    {

        //private int visitorId;
        //private string login;
        //private string mdp;


        //public int VisitorId { get; set; }
        [Required(ErrorMessage = "Le Login est obligatoire")]
        [Display(Name ="Login")]
        [Key]
        public string Login { get; set; }
        [Required(ErrorMessage = "Le mot de passe est obligatoire")]
        [Display(Name = "Mot de passe")]

        public string Mdp { get; set; }


        public Visitor()
        {
        }

        public Visitor(string login, string mdp)
        {
            Login = login;
            Mdp = mdp;
        }



        //public Visitor(string login, string mdp)
        //{
        //    this.login = login;
        //    this.mdp = mdp;
        //}
    }
}