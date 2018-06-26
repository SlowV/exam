using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using Exam.entity;

namespace Exam.controller
{
    public class ProductController
    {
        List<Product> pList = new List<Product>();

        public void Add()
        {
            Product product = new Product();
            while (true)
            {
                Console.WriteLine("Please enter product information.");
                Console.WriteLine("Product ID: ");
                var pID = Console.ReadLine();
                Console.WriteLine("Product name: ");
                var pName = Console.ReadLine();
                Console.WriteLine("Price");
                var pPrice = Console.ReadLine();
                product = new Product(pID, pName, pPrice);
                pList.Add(product);
                for (int i = 0; i < pList.Count; i++)
                {
                    Console.WriteLine(pList[i].ProductId + pList[i].ProductName + pList[i].Price);
                }
//                Console.WriteLine($"{"Product ID",8}|{"Product Name",10}|{"Price",5}");
//                Console.WriteLine($"{"--------",8}|{"----------",10}|{"-----",5}");
//                foreach (var item in pList)
//                {
//                    Console.WriteLine($"{item.ProductId,8}|{item.ProductName,10}|{item.Price,5}");
//                    Console.WriteLine($"{"--------",8}|{"----------",10}|{"-----",5}");
                // }

                Console.WriteLine("Next Y/N");
                var choice = Console.ReadLine();
                if (choice == "N")
                {
                    Program.GenerateMenu();
                }
                else if(choice == "Y")
                {
                    Console.ReadLine();
                }
            }
        }

        public void Display()
        {
            if (pList != null)
            {
//                
                for (int i = 0; i < pList.Count; i++)
                {
                    Console.WriteLine(pList[i].ProductId + pList[i].ProductName + pList[i].Price);
                }
            }

            else
            {
                Console.WriteLine("Notthing.");
            }
        }

        public void Delete()
        {
        }
    }
}