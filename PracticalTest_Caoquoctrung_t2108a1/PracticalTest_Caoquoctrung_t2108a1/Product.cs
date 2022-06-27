using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest_Caoquoctrung_t2108a1
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public double price { get; set; }
        public Product() { }
        public Product(int productId, string productName, double price)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
        }
    
        public void Display()
        {
            Console.WriteLine(this);
        }
       

        public override string ToString()
        {
            return String.Format("Product's ID: {0} \t Product's Name: {1} \t Product's Price: {2,6:C}\n", productId, productName, price);
        }
    }
}
