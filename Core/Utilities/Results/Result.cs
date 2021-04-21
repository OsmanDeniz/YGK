using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        /// <summary>
        /// Programci burada islem durumu ve mesajini verir.
        /// Success bilgisini tekrar etmemek icin mesaj da girildiginde diger constructori da tetikleyip onu da calistiriyor.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        /// <summary>
        /// Burada sadece islemin durumunu geri dondurebilir.
        /// </summary>
        /// <param name="success"></param>
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
