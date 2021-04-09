

using System;
using System.Collections.Generic;

namespace ConsoleApp10

{
    interface cetak
    {
        void cetak();
    }




    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Masukkan Nama Anda: ");
            string Nama = Console.ReadLine();
            Order order = new Order(Nama);
            Console.WriteLine("Apakah ingin memesan?(1: yes , 0: no)");
            int lanjutPesan = Convert.ToInt32(Console.ReadLine());

            if (lanjutPesan == 1)
            {
                inginPesan(lanjutPesan);
            }
            else
            {
                Console.WriteLine("Anda Keluar Dari Program. TerimaKasih");
            }

            while (lanjutPesan != 0)
            {
                Console.WriteLine("Apakah ingin memesan lagi ?(1: yes , -1: no)");
                lanjutPesan = Convert.ToInt32(Console.ReadLine());
                if (lanjutPesan == 1)
                {
                    inginPesan(lanjutPesan);
                }
                else
                {
                    order.HitungTotalBayar();
                    Console.WriteLine("Total Order :");

                    order.cetak();

                    break;
                }
            }

                void inginPesan(int x)
                {
                    if (lanjutPesan != 0 && lanjutPesan != -1)
                    {
                        MenuData.loadMenuData();
                        int i = 0;
                        foreach (Menu menu in MenuData.menuData)
                        {
                            Console.WriteLine("{0}.{1}........{2}", i, menu.Nama, menu.Harga);
                            i++;
                        }

                        Console.WriteLine("Masukkan kode menu:");
                    Menu menuTerpilih;
                    bool adaError = true;
                    int kodeMenu= 0;
                    while (adaError==true)
                    {
                        try
                        {
                            kodeMenu = Convert.ToInt32(Console.ReadLine());

                            menuTerpilih = MenuData.menuData[kodeMenu];
                            adaError = false;
                        }
                        catch(Exception e)
                        {
                            adaError = true;
                            Console.WriteLine("Input yang anda masukkan salah!");
                        }
                        
                    }
                    menuTerpilih = MenuData.menuData[kodeMenu];
                    OrderItem orderItem;
                        if (menuTerpilih.Kue == true)
                        {
                            orderItem = new Kue(menuTerpilih);
                        }
                        else
                        {
                            orderItem = new Minuman(menuTerpilih);
                        }
                        orderItem.customerQuery();
                        orderItem.hitungHargaOrderItem();
                        orderItem.hargaBayar();
                        orderItem.cetak();
                        order.addOrderItem(orderItem);

                        Console.WriteLine("Kode menu adalah: " + MenuData.menuData[kodeMenu].Nama);
                    }




                


            }


        }
    }
}
