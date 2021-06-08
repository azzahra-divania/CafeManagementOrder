using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    class OrderXTransaksiController
    {
        public List<Order> orders { get; set; }
        public decimal hargaItemXQty { get; }

        public OrderXTransaksiController()
        {
            this.orders = new List<Order>();
        }

        public void addOrderItem(Order order)
        {
            orders.Add(order);
        }
    }
}
