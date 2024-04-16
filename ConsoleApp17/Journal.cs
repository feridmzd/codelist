using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Journal:Product
    {

        
      public string Company { get; set; }

     public override string GetInfo()
    {
      return $"Journal: {Name} by {Company}, Price: {Price}";
    }
        

    }
}
