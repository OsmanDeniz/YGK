using Business.Abstract;
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
            ProductManager productManager = new ProductManager(new efProductDal());
            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.ProductName +" -> "+ p.UnitPrice);
            }
        }
    }
}
