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
        //private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            //TheUser th01 = new TheUser("login", "mdp", "nom", "prenom");         
            //Visitor vi01 = new Visitor("login", "mdp");

            //db.TheUsers.Add(th01);
            //db.Visitors.Add(vi01);
            //db.SaveChanges();

            //using(IDal dal = new Dal())
            //{
            //    dal.TestVote();
            //    dal.EssaiRetau();
            //}

            //ViewData["message"] = "Bonjour depuis le contrôleur";
            //ViewData["date"] = DateTime.Now;
            //Restaurant r = new Restaurant { Nom = "La bonne fourchette", Adresse = "1234" };

            using (IDal dal = new Dal())
            {
                //List<Restaurant> ListeDesRestos = dal.GetRestaurants();

                

                AccueilViewModel vm = new AccueilViewModel
                {


                    Message = "Bonjour depuis le contrôleur",
                    Date = DateTime.Now,
                    Resto = new Restaurant { Nom = "La bonne fourchette", Adresse = "1234" },
                    ListeDesRestos = dal.GetRestaurants(),
                    
            };
                
                return View(vm);

            }

                
        }

        public ActionResult Index02()
        {

            using (IDal dal = new Dal())
            {
                List<Models.Restaurant> listeDesRestos = dal.GetRestaurants();
                //le 2 correspond a l id qui sera afficher par défault
                ViewBag.ListeDesRestos = new SelectList(listeDesRestos, "RestaurantId", "Nom",2);
            }
            return View("Index02");
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