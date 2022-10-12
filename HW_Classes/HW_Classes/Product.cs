using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Classes
{
    internal class Product
    {
        public string Name { get; set; }
        public DateTime ManufactureDate { get; }
        public decimal Price { get; set; }
        public Product() { }

        public Product(string name)
        {
            ManufactureDate = DateTime.Now;
            Name = name;
        }

        public override string ToString()
        {
            string product_info = "\nName: " + Name + "\nManufactureDate: " + "\nPrice: " + Price;
            return product_info;
        }
    }
}
