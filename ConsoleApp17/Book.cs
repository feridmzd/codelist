using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp17                                                        
{
    public class Book
    {                  
        public int Id { get; set; }              
                                                       
        public string Name { get; set; }            
        public string AuthorName;              
                       
                                                                        
                           
        public Book(int id, string name, string authorName)
        {
            Id = id;             
            Name = name;                              
           AuthorName = authorName;                         
               
        }                                   
        public void AddBook(Book book)           
        {
            book.Add(book);                                                                                  
        }
        public void ShowAllBooks()
        {
            Console.WriteLine($"{Id}\n{Name}\n{AuthorName}");
        }

        //public Book FindBookById(int id)
        //{
        //    foreach (var br in Books)
        //    {
        //        if (br.Id == id)
        //        {
        //            br.();
        //        }
        //    }
        //    return null;
        //}














        private void Add(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
