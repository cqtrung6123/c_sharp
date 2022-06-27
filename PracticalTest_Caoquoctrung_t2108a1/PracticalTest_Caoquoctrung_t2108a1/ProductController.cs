using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest_Caoquoctrung_t2108a1
{
     class ProductController
    {
        List<Product> products = new List<Product>();
       

        public void AddProduct()
        {
            Product product = new Product();
            Console.WriteLine("Please, Enter Product's Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, Enter Product's Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please, Enter Product's Price: ");
            double price = double.Parse(Console.ReadLine());
            Product product2 = new Product(id,name,price);
            products.Add(product2);
        }
        public void GetAllProduct()
        {
            foreach (Product product in products)
            {
                product.Display();
            }
        }


        public void DeleteById()
        {
            
            Console.WriteLine("please enter the product id you want to delete");
            int id=int.Parse(Console.ReadLine());
            foreach (Product product in products)
            {
                if (id==product.productId)
                {
                    products.Remove(product);
                    Console.WriteLine("Delete successful");
                }
                else
                {
                    Console.WriteLine("Not Found !");
                }
            }
        }
    }
}
