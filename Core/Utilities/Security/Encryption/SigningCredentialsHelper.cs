using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
    /// <summary>
    /// Jwt sistemi icin algoritma ve HmacSha512Signature algoritma kismi (*?)
    /// </summary>
    public class SigningCredentialsHelper
    {
        /// <summary>
        /// HmacSha512Signature algoritmasi ve security key kullanarak jwt sistemi olusturma islemi
        /// </summary>
        /// <param name="securityKey">Kullanilacak olan guvenlik anahtari </param>
        /// <returns></returns>
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }

    }
}
