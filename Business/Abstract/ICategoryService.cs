using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    /// <summary>
    /// Dis dunyaya servis etmek istedigimiz aksiyonlar burada yer alir
    /// </summary>
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);

    }
}
