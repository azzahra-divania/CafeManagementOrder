using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    class MenuController
    {
        public static List<Menu> GetAllMenu()
        {
            List<Menu> menuList = new List<Menu>();
            using (var db = new cafeEntities())
            {
                var query = from menu in db.Menus orderby menu.ismakanan ascending select menu;

                foreach (var item in query)
                {
                    menuList.Add(item);
                    //   lblNama.Text = item.nama_menu;
                    //   lblHarga.Text = item.harga.ToString();
                    //  pictureBox1.Image = CommonTools.ByteToImage(item.gambar_menu);

                }
            }
            return menuList;
        }

        public static Menu GetMenuById(int id)
        {
            List<Menu> menuList = new List<Menu>();
            using (var db = new cafeEntities())
            {
                var query = from menu in db.Menus where menu.menu_id == id select menu;

                foreach (var item in query)
                {
                    menuList.Add(item);
                    //   lblNama.Text = item.nama_menu;
                    //   lblHarga.Text = item.harga.ToString();
                    //  pictureBox1.Image = CommonTools.ByteToImage(item.gambar_menu);

                }
            }
            return menuList[0];
        }

    }
}
