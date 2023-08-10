using productos_tienda;
using productos_tienda.View;



internal class Program
{
    private static void Main(string[] args)
    {
        MainMenu menu = new();
        int option = 0;
        do
        {
            option = menu.showMenu();
            Product product = new Product();

            switch (option)
            {
                case 1:
                    Product newProduct = product.CreateProduct();
                    Env.Products.Add(newProduct);
                    string json = JsonConvert.SerializeObject(Env.Products, Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    break;
            }


        } while (option != 6);
    }

    private class JsonConvert
    {
    }
}