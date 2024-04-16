using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
   public  class Bookk:Product
    {
       
       
     public string Author { get; set; }
      public string Genre { get; set; }


       
    public override string GetInfo()
    {
          return $"Book: {Name} by {Author}, Genre: {Genre}, Price: {Price}";
    }
 }


   
}

