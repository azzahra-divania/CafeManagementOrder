using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    public class Menu : cetak
    {
        public bool Kue { get; set; }

        public int Harga { get; set; }
        public string Nama { get; set; }
        
        
        public void cetak()
        {

        }


        public Menu(string nama, int harga, bool Kue)
        {
            this.Harga = harga;
            this.Nama = nama;
            this.Kue = Kue;
        }
    }
}
