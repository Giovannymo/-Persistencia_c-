namespace productos_tienda;

    public class Env
    {
        private static string fileName = "products.json";
        private static List<Product> products = new List<Product>();
        public static string FileName {get => fileName; set => fileName = value; }
        public static List<Product> Products {get => products; set => products = value;}
    
        
    }
