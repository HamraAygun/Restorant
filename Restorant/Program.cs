
using Restorant;

internal class Program
{
    private static void Main(string[] args)
    {
        //Kategori
        clsCategory clsCategory = new clsCategory();
        clsCategory.CADID = 1;
        clsCategory.CatName = "Çorbalar";

        Console.WriteLine("Kategori Listesi");
        Console.WriteLine("=========" + "\n\n");
        Console.WriteLine(clsCategory.CADID + "\t" + clsCategory.CatName);

        //Food

        clsMenu clsMenu = new clsMenu();

        clsMenu.MenuID = 2;
        clsMenu.MenuName = "P100KY Restorant Menü";
        clsMenu.FoodName = "Mercimek Çorba";
        clsMenu.FoodPrice = 40;
        clsMenu.CatID = 1;

        Console.WriteLine(clsMenu.MenuName + "Yemek Listesi: ");
        Console.WriteLine("======== " + "\n\n");
        Console.WriteLine(clsMenu.MenuID + "\t" + clsMenu .FoodName + "\t" + clsMenu.FoodPrice + "TL");


        clsRaw clsRaw = new clsRaw();

        clsRaw.RawID = 3;
        clsRaw.RawName = "onion";
        clsRaw.RawAmount = 1;

        Console.WriteLine("Malzemeler Listesi");
        Console.WriteLine("======== " + "\n\n");
        Console.WriteLine(clsRaw.RawID + "\t" + clsRaw.RawName + "\t" + clsRaw.RawAmount + "kg");

        


      
        Console.ReadKey();
    }
}