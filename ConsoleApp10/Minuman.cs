using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Minuman : OrderItem, cetak
    {
        private enum Size { S, M, L };
        private Size size;
        private bool bawaTumblr;
        private enum topping { caramel, cream, chocosauce };
        private topping Topping;
        
        public Minuman ( Menu menu)
        {
            base.menu = menu;
        }
        public override double hitungHargaOrderItem()
        {
            HargaOrderItem = menu.Harga;
            
            if (size == Size.M)
            {
                HargaOrderItem += 6000;
            }
            else if(size == Size.L)
            {
                HargaOrderItem += 7000;
            }
            if (Topping == topping.caramel)
            {
                HargaOrderItem += 5000;
            }
            else if(Topping == topping.cream)
            {
                HargaOrderItem += 5000;
            }
            else if(Topping == topping.chocosauce)
            {
                HargaOrderItem += 4000;
            }
            if (bawaTumblr == true)
            {
                HargaOrderItem -= 10000;
            }
            
            return HargaOrderItem;

        }

        public override void customerQuery()
        {
            base.customerQuery();
            Console.WriteLine("Ukuran yang dipilih, S, M, atau L?");
            bool ukuranBetul=false;
            while (ukuranBetul == false)
            {
                string sizes = Console.ReadLine();
                
                if (string.Equals(sizes, "s", StringComparison.OrdinalIgnoreCase))
                {
                    this.size = Size.S;
                    ukuranBetul = true;
                }
                else if (string.Equals(sizes, "m", StringComparison.OrdinalIgnoreCase))
                {
                    this.size = Size.M;
                    ukuranBetul = true;
                }
                else if (string.Equals(sizes, "l", StringComparison.OrdinalIgnoreCase))
                {
                    this.size = Size.L;
                    ukuranBetul = true;
                }
                else
                {
                    Console.WriteLine("Input yang anda masukkan salah! Coba Lagi.");
                }
            }
        
            Console.WriteLine("Apakah ingin memesan menggunakan tumblr(y/n)?");
            bool tumblrBetul = false;
            while (tumblrBetul == false)
            {
                string Tumblr = Console.ReadLine();
                if (string.Equals(Tumblr, "y", StringComparison.OrdinalIgnoreCase))
                {

                    this.bawaTumblr = true;
                    tumblrBetul = true;
                }
                else if (string.Equals(Tumblr, "n", StringComparison.OrdinalIgnoreCase))
                {
                    
                    this.bawaTumblr = false;
                    tumblrBetul = true;
                }
                else
                {
                    Console.WriteLine("Input yang anda masukkan salah! Coba Lagi.");
                }
            }
            Console.WriteLine("Ingin tambah topping apa?");
            Console.WriteLine("1: caramel sauce, 2:whipppedcream, 3:chocolate sauce");
            bool toppingBetul = false;
            while (toppingBetul == false)
            {
                string Topping = Console.ReadLine();
                if (string.Equals(Topping, "1", StringComparison.OrdinalIgnoreCase))
                {
                    this.Topping = topping.caramel;
                    toppingBetul = true;
                }
                else if (string.Equals(Topping, "2", StringComparison.OrdinalIgnoreCase))
                {

                    this.Topping = topping.cream;
                    toppingBetul = true;
                }
                else if (string.Equals(Topping, "3", StringComparison.OrdinalIgnoreCase))
                {

                    this.Topping = topping.chocosauce;
                    toppingBetul = true;
                }
                else
                {
                    Console.WriteLine("Input yang anda masukkan salah! Coba Lagi.");
                }
            }
            


        }
        public  override void cetak()
        {
            base.cetakBase();
            Console.WriteLine("Size Minuman : {0}", size);
            Console.WriteLine("Bawa Tumblr: {0}", bawaTumblr);
            Console.WriteLine("Topping : {0}", Topping);
            
        }
    }
}
