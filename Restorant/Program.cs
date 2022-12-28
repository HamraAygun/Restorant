
using Restorant;

internal class Program
{
    private static void Main(string[] args)
    {
        //Kategori
        clsCategory clsCategory = new clsCategory();

        clsCategory.CADID = 1;
        clsCategory.CatName = "Borç çorbası";


        clsCategory.CADID = 2;
        clsCategory.CatName = "Çorbalar";

        Console.WriteLine("Kategori Listesi");
        Console.WriteLine("=========" + "\n");
        Console.WriteLine(clsCategory.CADID + "\t" + clsCategory.CatName);

        //Food

        clsMenu clsMenu = new clsMenu();

        clsMenu.MenuID = 2;
        clsMenu.MenuName = "P100KY Restorant Menü";
        clsMenu.FoodName = "Mercimek Çorba";
        clsMenu.FoodPrice = 40;
        clsMenu.CatID = 1;

        Console.WriteLine(clsMenu.MenuName + "\t" + "Yemek Listesi: ");
        Console.WriteLine("======== " + "\n");
        Console.WriteLine(clsMenu.MenuID + "\t" + clsMenu .FoodName + "\t" + clsMenu.FoodPrice + "TL");

        //Raw - Ham madde 

        clsRaw clsRaw = new clsRaw();

        clsRaw.RawID = 1;
        clsRaw.RawName = "Yeşil Mercimek";
        clsRaw.RawAmount = 5;

        Console.WriteLine("Malzemeler Listesi");
        Console.WriteLine("======== " + "\n");
        Console.WriteLine(clsRaw.RawID + "\t" + clsRaw.RawName + "\t" + clsRaw.RawAmount + "paket");

        Console.ReadKey();
    }
}