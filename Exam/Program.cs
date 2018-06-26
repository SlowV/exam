using System;
using System.Collections.Generic;
using Exam.controller;

namespace Exam
{
    class Program
    {
        static ProductController controller = new ProductController();
        static void Main(string[] args)
        {
            GenerateMenu();
        }

        public static void GenerateMenu()
        {
           

            Console.WriteLine("--------- Product ----------");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    controller.Add();
                    Console.ReadLine();
                    break;
                case 2:
                    Display();
                    break;
                case 3:
                    controller.Delete();
                    break;
                case 4:
                    Console.WriteLine("Bye bye.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (choice == 4)
            {
                Environment.Exit(1);
            }
        }

        private static void Display()
        {
            
        }
    }
}