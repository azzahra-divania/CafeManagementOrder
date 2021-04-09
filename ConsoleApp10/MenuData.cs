using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class MenuData
    {
        public static List<Menu> menuData;

        public static void loadMenuData()
        {
            menuData = new List<Menu>();

            menuData.Add(new Menu("Americano", 40000, false));
            menuData.Add(new Menu("Misto", 45000, false));
            menuData.Add(new Menu("Vanilla SweetCream", 47000, false));
            menuData.Add(new Menu("Asian Dolce Latte", 46000, false));
            menuData.Add(new Menu("Caramel Frappuchino", 49000, false));
            menuData.Add(new Menu("Caramel JavaChip", 50000, false));
            menuData.Add(new Menu("Dark Mocha Frappuchino", 42000, false));
            menuData.Add(new Menu("Espresso Frappuchino", 45000, false));
            menuData.Add(new Menu("Green Tea Cream Frappuchino", 48000, false));
            menuData.Add(new Menu("Mocha Jelly Frappuchino", 40000, false));
            menuData.Add(new Menu("Vanilla Cream", 45000, false));
            menuData.Add(new Menu("Cafe Latte", 43000, false));
            menuData.Add(new Menu("Caramel Machiatto", 21000, false));
            menuData.Add(new Menu("Espresso Con Panna", 43000, false));
            menuData.Add(new Menu("Cold Foam Espresso", 46000, false));
            menuData.Add(new Menu("Cocoa Cappuchino", 47000, false));
            menuData.Add(new Menu("Espresso Frappuchino", 42000, false));
            menuData.Add(new Menu("Caffe Mocha", 46000, false));
            menuData.Add(new Menu("Almond Croissant", 25000, true));
            menuData.Add(new Menu("Butter Croissant", 24000, true));
            menuData.Add(new Menu("Caramel Stroopwafel", 29000, true));
            menuData.Add(new Menu("Cheese Begels", 23000, true));
            menuData.Add(new Menu("Cinammon Roll", 27000, true));
            menuData.Add(new Menu("New York Cheesecake", 25000, true));
            menuData.Add(new Menu("Peanut Butter Panini", 30000, true));
            menuData.Add(new Menu("Scarlet Velvet Cake", 26000, true));
            menuData.Add(new Menu("Nutella Bombolone", 20000, true));
            menuData.Add(new Menu("Oreo Cheesecake", 27000, true));
            menuData.Add(new Menu("Espresso Brownie", 26000, true));
            menuData.Add(new Menu("Cheese Quiche", 26000, true));


        }
    }
}
