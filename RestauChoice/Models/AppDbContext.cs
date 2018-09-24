using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestauChoice.Models
{
    public class AppDbContext:DbContext
    {
        public DbSet<TheUser> TheUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Evenement> Evenements { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Vote> Votes { get; set; }
    }
}