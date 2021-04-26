using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Microsoft.Extensions.Options;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool // static tek bir kere olusturulur
    {
        /// <summary>
        /// Gonderilen entitynin, ilk parametrede gonderilen validator kurallarina uyup uymadiginin kontrolu yapilir.
        /// </summary>
        /// <param name="validator"></param>
        /// <param name="entity"></param>
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }

    }
}
