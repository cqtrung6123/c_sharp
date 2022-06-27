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
        public void Input()
        {
            Console.WriteLine("Please, Enter Product's Id: ");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Please, Enter Product's Name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Please, Enter Product's Price: ");
            double price=double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
       

        public override string ToString()
        {
            return String.Format("Product's ID: {0} || Product's Name: {1} || Product's Price: {2,6:C}", productId, productName, price);
        }
    }
}
