using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauChoice.Models
{
    interface IDal:IDisposable
    {

        void EssaiRetau();
        List<Restaurant> GetRestaurants();
        void CreateResto(string nom, string adresse);
        TheUser TestConnection(Visitor visitor);
        TheUser CreateUser(Models.TheUser TheUsers);

        void DataTestRestoType();
        Restaurant TestRestaurantWithType();
    }
}
