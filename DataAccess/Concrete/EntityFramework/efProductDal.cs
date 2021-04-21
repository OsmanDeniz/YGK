using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class efProductDal : efEntityRepositoryBase<Product, efNorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (efNorthwindContext context = new efNorthwindContext())
            {
                // kategoriler ile urunleri id ye gore birlestir ve bana productDetailDto ya gore uydur ver

                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 UnitsInStock = p.UnitsInStock,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
