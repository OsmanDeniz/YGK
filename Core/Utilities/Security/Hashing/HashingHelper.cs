using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    /// <summary>
    /// Hash olusturma ve hash dogrulama islemleri
    /// </summary>
    public class HashingHelper
    {
        /// <summary>
        /// Girilen password e gore hash ve salt degerleri hesaplayip verir
        /// </summary>
        /// <param name="password"> Hash olusturulacak parola </param>
        /// <param name="passwordHash">parolaya gore olusan hash</param>
        /// <param name="passwordSalt">parolaya gore olusan salt </param>
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

        }

        /// <summary>
        /// Eger sana boyle bir password gelseydi hesaplayacagin hash passwordHash bilgisine esit olur muydu
        /// </summary>
        /// <param name="password">Dogrulanacak parola </param>
        /// <param name="passwordHash">Hesaplanan dogrulama hashi</param>
        /// <param name="passwordSalt">Hesaplanirken salt key degeri</param>
        /// <returns></returns>
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                        return false;
                }
            }
            
            return true;
        }
    }
}
