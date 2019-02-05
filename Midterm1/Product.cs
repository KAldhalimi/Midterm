using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm1
{
    class Product
    {
        public string Name;
        public string Category;
        public string Description;
        public double price;

        public Product(string Name, string Category, string Description, double price)
        {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
            this.price = price;

        }

        internal void PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}