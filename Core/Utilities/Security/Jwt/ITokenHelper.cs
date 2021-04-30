using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Security.Jwt;

namespace Core.Utilities.Security
{
    public interface ITokenHelper
    { /// <summary>
      /// Ilgili kullanici icin ilgili claimleri icerek token uretmek icin
      /// </summary>
      /// <param name="user"></param>
      /// <param name="operationClaims"></param>
      /// <returns></returns>
        AccessToken CreateAccessToken(User user, List<OperationClaim> operationClaims);
    }
}
