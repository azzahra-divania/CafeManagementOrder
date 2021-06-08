using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    class ToppingController
    {
        public static List<Topping> getAllTopping()
        {
            List<Topping> toppingList = new List<Topping>();
            using (var db = new cafeEntities())
            {
                var query = from topping in db.Toppings select topping;

                foreach (var item in query)
                {
                    toppingList.Add(item);

                }
            }
            return toppingList;
        }

        public static Topping getToppingById(int id)
        {
            List<Topping> toppingList = new List<Topping>();
            using (var db = new cafeEntities())
            {
                var query = from Topping in db.Toppings where Topping.topping_id == id select Topping;
                foreach (var item in query)
                {
                    toppingList.Add(item);

                }
            }
            return toppingList[0];
        }
    }
}

