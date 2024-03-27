using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Product
    {
        private int _price;
        private int _count;
        public int No;//mehsulun nomresi
        public string Name;
        public int Price 
        {
            get 
            {  
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }
        }
        public Product() { }
        public Product(int price) 
        { 
            _price = price;
        }
        public Product(int price, int count):this(price)
        {
            _count = count;
        }
        public Product(int price, int count, int no) : this(price,count)
        {
           No = no;
        }
        public Product(int price, int count, int no,string name) : this(price, count,no)
        {
            Name = name;
        }
    }
}
