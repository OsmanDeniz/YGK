using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.Utilities.Results
{
    /// <summary>
    /// Burada geriye bir turde veri doner ve mesajlar IResult uzerinden kullanilir.
    /// Ornek : T degeri List<Product> olabilir. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
