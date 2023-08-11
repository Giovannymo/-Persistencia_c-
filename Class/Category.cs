namespace productos_tienda;

    public class Category
    {
        public int CategoryID { get; set; }
        public string Description { get; set; }

        public Category(){

        }

        public Category(int _categoryID, string _description){
            this.CategoryID = _categoryID;
            this.Description = _description;
        }

        public Category CreateCategory(){
            try{

                Console.WriteLine("Ingrese el ID de la categoria");
                int idCategory = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Nombre de la categoria: ");
                string NameCategory = Console.ReadLine();

                Category category = new Category(idCategory, NameCategory);
                return category;
            

            }catch(Exception e){
                throw new Exception("Hubo una excepciòn, intentelo de nuevo\n"+e.Message);
            }

            return null;
        }


        public void ShowCategories(List<Category> categories)
        {
            Console.WriteLine("{0,-30} {1,10}", "ID", " Categoria");
            foreach (Category category in categories){
                Console.WriteLine("{0,-32} {1,7}", category.CategoryID, category.Description);

            }
        }

        
    }
