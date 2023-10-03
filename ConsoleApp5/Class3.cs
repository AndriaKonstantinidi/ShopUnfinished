using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Shop
    {
        public string Name { get; set; }
        List<Products> products = new List<Products> {
            new Products() { ProductName = "Cough Medicine", Price = 5, Inventory = 150, Id = 1 },
            new Products() { ProductName = "Bread", Price = 2, Inventory = 500, Id = 2 },
            new Products() { ProductName = "Soda", Price = 1, Inventory = 200, Id = 3 },
            new Products() { ProductName = "Eggs", Price = 7, Inventory = 400, Id = 4 }
        };
        public void Productlist()
        {
            foreach(var product in products)
            {
                Console.WriteLine($"Name : {product.ProductName}");
                Console.WriteLine($"Price : {product.Price}");
                Console.WriteLine($"Stock : {product.Inventory}");
                Console.WriteLine($"ID : {product.Id}");
                Console.WriteLine("-----------");
            }
        }
        public void ProductPicker()
        {
            Console.WriteLine("Choose your product:");
            int input = Console.Read();
        }
    }
}
