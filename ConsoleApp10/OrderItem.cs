using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public abstract class OrderItem : cetak
    {
        public int qty { get; set; }
        private double pajak;
        private double besarPajak; 
        public double hargaOrderItemxQty { get; set; }
        public double HargaOrderItem { get; set; }
        public Menu menu { get; set; }
        public abstract double hitungHargaOrderItem();
        public  virtual void customerQuery()
        {
            Console.WriteLine("Ingin Order Berapa Buah?");
            this.qty = Convert.ToInt32(Console.ReadLine());

        }
        public void  hargaBayar()
        {
            besarPajak = 0.0;
            pajak = 0.02;
            besarPajak = (HargaOrderItem * qty) * pajak;
            hargaOrderItemxQty = (HargaOrderItem * qty) + besarPajak;
        
        }
        protected void cetakBase()
        {
            Console.WriteLine("Pesanan : {0}", menu.Nama);
            Console.WriteLine("Harga : {0}", HargaOrderItem);
            Console.WriteLine("Jumlah : {0}", qty);
            Console.WriteLine("PPN : {0}", besarPajak);
            Console.WriteLine("HargaTotal : {0}", hargaOrderItemxQty);
        }
        public abstract void cetak();
        
       



    }
}
