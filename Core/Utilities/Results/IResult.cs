using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    /// <summary>
    /// Void fonksiyonlar icin durum ve mesaj bilgisi donen bir interface
    /// </summary>
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
