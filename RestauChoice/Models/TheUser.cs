using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauChoice.Models
{
    public class TheUser:Visitor
    {

        //private string nom;
        //private string prenom;
        public int TheUserId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Evenement> Evenements { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }

        public TheUser()
        {
            this.Comments = new HashSet<Comment>();
            this.Evenements = new HashSet<Evenement>();
            this.Votes = new HashSet<Vote>();
        }

        public TheUser(string login, string mdp, string nom, string prenom) : base(login, mdp)
        {
            Nom = nom;
            Prenom = prenom;
        }



        //public TheUser(string login, string mdp, string nom, string prenom):base(login,mdp)
        //{
        //    this.nom = nom;
        //    this.prenom = prenom;
        //}




        //public void Test()
        //{
        //    TheUser u01 = new TheUser("login", "mdp", "nom", "prenom");
        //    string loTest = u01.Login;
        //    Console.WriteLine(loTest);
        //    u01.Login = "changement";
        //    Console.WriteLine(u01.Login);
        //    //ca nexiste pas
        //    int id = u01.VisitorId;
        //    Console.WriteLine(id);
        //    Console.ReadLine();
        //}

    }

  
}