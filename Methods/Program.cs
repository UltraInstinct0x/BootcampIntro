using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";
            product1.UnitsInStock = 39;

            Product product2 = new Product();
            product2.Name = "Çilek";
            product2.Price = 10;
            product2.Description = "Dağ çileği";
            product2.UnitsInStock = 100;

            Product[] products = new Product[] { product1, product2, };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.UnitsInStock);
                Console.WriteLine("--------");
            };

            Console.WriteLine("------Metotlar-------");
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);

        }
    }
}
