using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauChoice.Models
{
    public class Dal:IDal
    {

        private AppDbContext bdd;

        public Dal()
        {
            bdd = new AppDbContext();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }

        public TheUser TestConnection(Visitor visitor)
        {
            try
            {


                TheUser theUserTest = bdd.TheUsers.Where(t => t.Login.Equals(visitor.Login)).SingleOrDefault();
                if (visitor.Mdp.Equals(theUserTest.Mdp))
                {
                    return theUserTest;
                }
            }catch(NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }

        public TheUser CreateUser(TheUser theUser)
        {
            TheUser theUserBase = bdd.TheUsers.Where(t => t.Login.Equals(theUser.Login)).SingleOrDefault();
            if (theUserBase != null)
            {
                return null;
            }
            else
            {
                bdd.TheUsers.Add(theUser);
                bdd.SaveChanges();
                return theUser;
            }
            
        }

        public void EssaiRetau()
        {
            Restaurant re01 = new Restaurant("restau 01", "Paris");
            Restaurant re02 = new Restaurant("restau 02", "Marseille");
            Restaurant re03 = new Restaurant("restau 03", "Lyon");
            bdd.Restaurants.Add(re01);
            bdd.Restaurants.Add(re02);
            bdd.Restaurants.Add(re03);
            bdd.SaveChanges();
        }

        public void CreateResto(string nom, string adresse)
        {
            Restaurant re01 = new Restaurant(nom, adresse);
            bdd.Restaurants.Add(re01);
            bdd.SaveChanges();
        }

        public List<Restaurant> GetRestaurants()
        {
            return bdd.Restaurants.ToList();
        }

    }
}