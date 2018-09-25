using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauChoice.Models
{
    interface IDal:IDisposable
    {
        void TestVote();
        void EssaiRetau();
        List<Restaurant> GetRestaurants();
    }
}
