using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Book:Product
    {
        public string Genre;
        public Book() { }
        public Book(string genre) 
        {
            this.Genre = genre;
        }
        public Book(string genre,int price,int count,int no,string name):base(price, count, no, name)
        {
            this.Genre = genre;
        }
        public void ShowInfo() 
        {
            Console.WriteLine($"Genre:{Genre}, Price:{Price}, Count:{Count}, No:{No}, Name:{Name}");
        }
    }
}
