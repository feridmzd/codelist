namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddProduct(new Bookk { Name = "Eli ve Nino", Author = "Dedeqorduq", Genre = "Romantik", Price = 20 })                      ;
            library.AddProduct(new Bookk { Name = "Leyli mecnun", Author = "Author2", Genre = "Genre2", Price = 30 });
            library.AddProduct(new Journal { Name = "Ekinci", Company = "Baki", Price = 10 });
            library.AddProduct(new Journal { Name = "Zerdust", Company = "Mingo", Price = 15 });

       
            Console.WriteLine("Enter min price:");
            double minPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter max price:");
            double maxPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

           
            List<Product> productsByPrice = library.GetProductsByPrice(minPrice, maxPrice);
            List<Product> productsByName = library.GetProductsByName(name);

          
            Console.WriteLine("Products by price:");
            foreach (var product in productsByPrice)
            {
                Console.WriteLine(product.GetInfo());
            }

            Console.WriteLine("Products by name:");
            foreach (var product in productsByName)
            {
                Console.WriteLine(product.GetInfo());
            }
        }
    }
}