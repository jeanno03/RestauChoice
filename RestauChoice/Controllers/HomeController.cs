using RestauChoice.Models;
using RestauChoice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauChoice.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index(Visitor visitor)
        {

            using (IDal dal = new Dal())
            {
                //add user
  
                //add resto
                //dal.EssaiRetau();
            }

            using (IDal dal = new Dal())
            {

                AccueilViewModel vm = new AccueilViewModel
                {


                    Message = "Bonjour nous sommes le",
                    Date = DateTime.Now,
                    ListeDesRestos = dal.GetRestaurants(),
                    TheUsers = dal.TestConnection(visitor),

                };
                
                return View(vm);

            }

                
        }

        public ActionResult PageConnexion()
        {
            return View();
        }

        public ActionResult TestConnexion(Visitor visitor)
        {
            using (IDal dal = new Dal())
            {
                TheUser userTest = dal.TestConnection(visitor);
                if (userTest!=null)
                {
                    AccueilViewModel vm = new AccueilViewModel
                    {

                        TheUsers = userTest,

                    };
                    return View(vm);
                }
                else
                {
                    return View("Error");
                }

            }

        }

        public ActionResult CreateTheUser()
        {
            return View();

        }

        public ActionResult ValidateCreateTheUser(TheUser theUser)
        {
            using (IDal dal = new Dal())
            {
                TheUser userTest = dal.CreateUser(theUser);
                if (userTest != null)
                {
                    AccueilViewModel vm = new AccueilViewModel
                    {

                        TheUsers = userTest,

                    };
                    return View(vm);
                }
                else
                {
                    return View("Error");
                }
            }
        }

            public ActionResult VoirResto()
        {
            using (IDal dal = new Dal())
            {
                ViewData["message"] = "Bonjour depuis le contrôleur";
                ViewData["date"] = DateTime.Now;
                ViewData["resto"] = new Restaurant { Nom = "Choucroute party", Adresse = "St Denis" };    

                List<Restaurant> listesDesRestaurants = dal.GetRestaurants();
            }
            return View("Resto");
        }

        //public ActionResult Connection()
        //{
        //    return View("Connection");
        //}

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