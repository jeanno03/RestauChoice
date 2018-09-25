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



        public void TestVote()
        {
            DateTime da = DateTime.Now;
            Vote vo01 = new Vote(da,1);
            TheUser th01 = new TheUser("AA", "AA", "AA", "AA");
            vo01.TheUser = th01;
            bdd.TheUsers.Add(th01);
            bdd.Votes.Add(vo01);
            bdd.SaveChanges();
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

        public List<Restaurant> GetRestaurants()
        {
            return bdd.Restaurants.ToList();
        }

    }
}