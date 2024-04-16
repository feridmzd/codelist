using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
   public  class Library 
    
    { 
    private List<Product> Products;

    public Library()
    {
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public List<Product> GetProductsByPrice(double minPrice, double maxPrice)
    {
        return Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
    }

   
        
    
        
        public List<Product> GetProductsByName(string name)
    {
        return Products.Where(p => p.Name.Contains(name)).ToList();
    }
        
    }
 }

