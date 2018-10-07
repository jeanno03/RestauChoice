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

        public Boolean TesterConnection(string login, string mdp)
        {
        if (login == "1" && mdp == "1")
            {
                return true;
            }
            return false;
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}