using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Library
    {
        public Book[] Books;
        public Library() 
        {
            Books = new Book[0];
        }    
        public void Addbook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length-1] = book;
        }
        public void GetFilteredBooks(string genre)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre==genre)
                {
                    Console.WriteLine(Books[i].Name);
                }
              
            }   
        }
        public void GetFilteredBooks(int minPrice,int maxPrice)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price>minPrice && Books[i].Price < maxPrice)
                {
                    Console.WriteLine(Books[i].Name);
                }
               
            }
        }
        public void ShowAllBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book.Name);
            };
            
        }
    }
}
