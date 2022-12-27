
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

        clsMenu.MenuID = 1;
        clsMenu.MenuName = "P100KY Restorant Menü";
        clsMenu.FoodName = "Merci Çorba";
        clsMenu.FoodPrice = 40;
        clsMenu.CatID = 1;

        Console.WriteLine(clsMenu.MenuName + "Yemek Listesi: ");
        Console.WriteLine("======== " + "\n\n");
        Console.WriteLine(clsMenu.MenuID.ToString() + "\t" + clsMenu .FoodName + "\t" + clsMenu.FoodPrice + "TL");


        
        Console.ReadKey();
    }
}