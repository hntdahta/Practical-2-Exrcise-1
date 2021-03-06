﻿using System;

namespace Practical_2_Exrcise_1
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("1. Add new Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Iterate product list");
            Console.WriteLine("4. Search product");
            Console.WriteLine("5. Exit");
        }
        static void Main(string[] args)
        {
            int choice = 6;
            Shop shop = new Shop();
            Menu();
            while (choice != 5)
            {
                Console.Write("\nSelect: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Product p = new Product();
                        shop.AddProduct(p);
                        break;
                    case 2:
                        shop.RemoveProduct();
                        break;
                    case 3:
                        shop.IterateProductList();
                        break;
                    case 4:
                        shop.SearchProduct();
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
