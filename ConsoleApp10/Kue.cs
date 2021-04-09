using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
        class Kue : OrderItem, cetak
        {
        public Kue(Menu menu)
        {
            base.menu = menu;
        }
       

        public override double hitungHargaOrderItem()
        {
            HargaOrderItem = this.menu.Harga;
            return HargaOrderItem;
        }
        public override void cetak()
        {
            base.cetakBase();
        }
    }
}
