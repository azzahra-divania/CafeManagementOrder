 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    class SizeController
    {
        public static List<Size> getAllSize()
        {
            List<Size> sizeList = new List<Size>();
            using (var db = new cafeEntities())
            {
                var query = from size in db.Sizes select size;

                foreach (var item in query)
                {
                    sizeList.Add(item);

                }
            }
            return sizeList;
        }

        public static Size getSizeById(string id)
        {
            List<Size> sizeList = new List<Size>();
            using (var db = new cafeEntities())
            {
                var query = from size in db.Sizes where size.size1 == id select size;
                foreach (var item in query)
                {
                    sizeList.Add(item);

                }
            }
            return sizeList[0];
        }
    }
}

