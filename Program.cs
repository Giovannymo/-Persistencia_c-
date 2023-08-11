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
            Product product = new();
            Category category= new();

            switch (option)
            {
                case 1:
                    Product newProduct = product.CreateProduct();
                    Env.Products.Add(newProduct);
             
                    //string json = JsonConvert.SerializeObject(Env.Products, Formatting.Indented);
                    //File.WriteAllText(Env.FileName, json);
                    break;
                case 3:
                    category.ShowCategories(Env.Categories);
                    break;
                
                case 4:
                    product.ShowProducts(Env.Products);
                    break;
                case 6:
                    Console.WriteLine("Cerramos el chuzo.");
                    break;
            }


        } while (option != 6);
    }

}