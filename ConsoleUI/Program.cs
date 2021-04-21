﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    /// <summary>
    /// Bu proje test amaclidir sadece
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ProductManagerTest();
            //CategoryManagerTest();

        }

        private static void CategoryManagerTest()
        {
            CategoryManager categoryManager = new CategoryManager(new efCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductManagerTest()
        {
            ProductManager productManager = new ProductManager(new efProductDal());
            foreach (var p in productManager.GetProductDetails())
            {
                Console.WriteLine(p.ProductName + " -> " + p.CategoryName);
            }
        }
    }
}
