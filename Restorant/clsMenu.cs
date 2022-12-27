using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorant
{
    internal class clsMenu
    {
        public clsMenu() // Yapıcı Metot (constructor)
        { 
        
        
        }
        public int MenuID { get; set; } //Menüdeki ürünün sıra numarası
        public string MenuName { get; set; }
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }
        public int CatID { get; set; }

    }
}
