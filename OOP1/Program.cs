﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5, 
                UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35};

            //PascalCase=ProductManager   //camelCase=productManager 
            //case sensitive 
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); // burda kamera çıkar


            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi); // burda 100 çıkar

           
        }
    }
}
