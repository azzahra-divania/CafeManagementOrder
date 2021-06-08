using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
  
        class OrderController
        {
            private const decimal hargaPakaiTumblr = -7000;
            public static decimal hitungHargaOrderxQty(Order order)
            {
                if (order.harga_total_per_item != 0)
                {
                    return order.quantity * order.harga_total_per_item;
                }
                else
                {
                    return order.quantity * hitungHargaOrder(order);
                }
            }
            public static decimal hitungHargaOrderxQty(OrderMinuman orderMinuman)
            {
                if (orderMinuman.harga_total_per_item != 0)
                {
                    return orderMinuman.quantity * orderMinuman.harga_total_per_item;
                }
                else
                {
                    return orderMinuman.quantity * hitungHargaOrder(orderMinuman);
                }
            }

            public static decimal hitungHargaOrder(Order order)
            {
                return order.Menu.harga;
            }

            public static decimal hitungHargaOrder(OrderMinuman orderMinuman)
            {
                decimal hargaOrder;

                decimal hargaMenuItem;
                decimal hargaTopping;
                decimal hargaSize;
                decimal hargaIsTumblr = 0;

                hargaMenuItem = orderMinuman.Menu.harga;
                hargaTopping = orderMinuman.Topping.harga;
                hargaSize = orderMinuman.Size1.harga;
                if (orderMinuman.isBawaTumblr == true)
                {
                    hargaIsTumblr = hargaPakaiTumblr;
                }
                hargaOrder = hargaMenuItem + hargaTopping + hargaSize + hargaIsTumblr;
                return hargaOrder;
            }
        }
    }

