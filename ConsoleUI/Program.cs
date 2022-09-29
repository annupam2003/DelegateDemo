using DelegateDemoLibrary;

namespace ConsoleUI;
public class Program
{
    static StockModule cart = new StockModule();
    public static void Main(string[] args)
    {
        Console.WriteLine("Delegatedemo");
        SaleProduct();
        decimal total = cart.TotalCalc(NoofItem, AfterDiscoutTotal);
        Console.WriteLine($"Total Sale {total}");
    }

    public static void NoofItem(List<ProductModel> productModels)
    {
        int NoofItem = productModels.Count();
        Console.WriteLine($"No of items is {NoofItem}");
    }
    public static decimal AfterDiscoutTotal(decimal Total)
    {
        if (Total > 250)
            return Total * 0.80M;
        else if (Total > 200)
            return Total * 0.85M;
        else if (Total > 100)
            return Total * 0.90M;
        return Total;
    }
    public static void SaleProduct()
    {
        cart.Items.Add(new ProductModel { Name = "abc", Price = 10.00M });
        cart.Items.Add(new ProductModel { Name = "asd", Price = 20.09M });
        cart.Items.Add(new ProductModel { Name = "qwe", Price = 30.80M });
        cart.Items.Add(new ProductModel { Name = "zxc", Price = 40.07M });
        cart.Items.Add(new ProductModel { Name = "wsx", Price = 50.60M });
    }
}