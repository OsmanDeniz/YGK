using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class efProductDal : IProductDal
    {
        public void Add(Product tEntity)
        {
            using (efNorthwindContext context = new efNorthwindContext())
            {
                var addedEntity = context.Entry(tEntity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product tEntity)
        {
            using (efNorthwindContext context = new efNorthwindContext())
            {
                var deletedEntity = context.Entry(tEntity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (efNorthwindContext context = new efNorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (efNorthwindContext context = new efNorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product tEntity)
        {
            using (efNorthwindContext context = new efNorthwindContext())
            {
                var updatedEntity = context.Entry(tEntity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
