using RestauChoice.Models;
using RestauChoice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauChoice.Controllers
{
    public class ConnexionController : Controller
    {
        // GET: Connexion
        public ActionResult Index()
        {
            return View();
        }


        // GET: Connexion
        public ActionResult TestConnexion(Visitor visitor)
        {
            using (IDal dal = new Dal())
            {
                AccueilViewModel vm = new AccueilViewModel
                {

                    TheUsers = dal.TestConnection(visitor),

                };
                
                return View(vm);

            }

        }


    }
}