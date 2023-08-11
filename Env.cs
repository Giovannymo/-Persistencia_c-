namespace productos_tienda;

    public class Env
    {
        private static string fileName = "products.json";
        private static List<Product> products = new List<Product>();
        private static List<Category> categories = new List<Category>();
        public static string FileName {get => fileName; set => fileName = value; }
        public static List<Product> Products {get => products; set => products = value;}
        public static List<Category> Categories {get => categories; set => categories = value;}

        
        
    }
