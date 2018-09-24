using RestauChoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauChoice.Controllers
{
    public class HomeController : Controller
    {
        //private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            //TheUser th01 = new TheUser("login", "mdp", "nom", "prenom");         
            //Visitor vi01 = new Visitor("login", "mdp");

            //db.TheUsers.Add(th01);
            //db.Visitors.Add(vi01);
            //db.SaveChanges();

            using(IDal dal = new Dal())
            {
                dal.TestVote();
            }


            return View();
        }

        public ActionResult Connection()
        {
            return View("Connection");
        }

        //[HttpPost]
        //public ActionResult TesterConnection(Visitor visitor)
        //{

        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}