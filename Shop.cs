using System;
using System.Collections;

namespace Practical_2_Exrcise_1
{
    class Shop
    {
        ArrayList ProductList = new ArrayList();
        public void AddProduct(Product p)
        {
            Console.Write("Name: ");
            p.Name = Console.ReadLine();

            do
            {
                Console.Write("Price (0 - 100): ");
                p.Price = double.Parse(Console.ReadLine());
                if (p.Price > 0 && p.Price <= 100) {
                }
                else Console.WriteLine("Price phai nhap lon hon 0 va be hon 100");
            } while (!(p.Price > 0 && p.Price <= 100));
            Console.Write("Description: ");
            p.Description = Console.ReadLine();
                Console.Write("Rate (1 - 5): ");
                int n = int.Parse(Console.ReadLine());
                p.Rate = new int[n];
                for (int i = 0; i < n; i++)
                {
                    if (p.Rate[i] >= 1 && p.Rate[i] <= 5)
                    {
                        Console.Write("Rate " + (i + 1) + ": ");
                        p.Rate[i] = int.Parse(Console.ReadLine());
                    }
                    else Console.WriteLine("Rate phai dat tu 1 den 5");
                }
            ProductList.Add(p);
        }
        public void RemoveProduct()
        {
            Console.Write("Nhap ten san pham muon xoa: ");
            String name = Console.ReadLine();
            foreach (Product p in ProductList)
            {
                if (name.Equals(p.Name))
                {
                    Console.WriteLine("Xoa thanh cong");
                    ProductList.Remove(p);
                    break;
                }
                else
                    Console.WriteLine("Khong tim thay ten san pham");
            }
        }
        public void IterateProductList()
        {
            foreach (Product p in ProductList)
            {
                p.ViewInfo();
                float AverateRate = 0;
                foreach (int item in p.Rate)
                {
                    AverateRate += item;
                }
                Console.WriteLine("Averate Rate: " + AverateRate / p.Rate.Length);
            }
        }
        public void SearchProduct()
        {
            double a, b;
            Console.WriteLine("Nhap 2 so de hien thong tin san pham o giua 2 so do");
            do
            {
                Console.Write("Nhap so dau tien: ");
                a = double.Parse(Console.ReadLine());
            } while (!(a > 0 && a <= 100));
            do
            {
                Console.Write("Nhap so thu hai (phai lon hon so thu nhat): ");
                b = double.Parse(Console.ReadLine());
            } while (!(a <= 100 && b > a));
            foreach (Product p in ProductList)
            {
                if (p.Price >= a && p.Price <= b)
                
                    p.ViewInfo();
                
                else Console.WriteLine("Khong tim thay");
            }
            
        }
    }
}
