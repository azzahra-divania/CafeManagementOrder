using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public  class Order : cetak
    {
       public  List<OrderItem> orderItems { get; set; }
       public string customerName { get; set; }
       private double totalBayar = 0; 


    public  Order (string Name)
        {
           this.customerName = Name;
           this.orderItems = new List<OrderItem> ();
        }
        
        
 
        public void addOrderItem(OrderItem x)
        {
           orderItems.Add(x);
        }
        
        public void HitungTotalBayar()
        {
            foreach (OrderItem orderitem in orderItems)
            {
                this.totalBayar += orderitem.hargaOrderItemxQty;
                
            }
        }
        public   void cetak()
        {
            Console.WriteLine("Customer Name :...... ..{0}", customerName);
            foreach (OrderItem orderitem in orderItems)
            {
                
                orderitem.cetak();
                Console.WriteLine("======================================");
            }
            Console.WriteLine("Total Harga Bayar : {0} ", totalBayar);
            


        }

        
    }
}
