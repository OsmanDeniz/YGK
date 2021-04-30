using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
    /// <summary>
    /// Kullanilacn SecurityKey i byte array haline getirilebilecek sinif
    /// </summary>
    public class SecurityKeyHelper
    {

        /// <summary>
        /// Verilen keyi byte arrayine cevirip simetrik keye cevirir
        /// </summary>
        /// <param name="securityKey">Security Key (appSettings.json)</param>
        /// <returns></returns>
        public static SecurityKey CreateSeciSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
