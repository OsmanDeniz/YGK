using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    /// <summary>
    /// Jwt Tarafindan olusturulan Token
    /// </summary>
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime ExpirationDataTime { get; set; }
    }
}
