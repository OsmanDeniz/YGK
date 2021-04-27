using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {

        public static IResult Run(params IResult[] logics) // params yazildigin de icerisine istenilen kadar kural verilebilir. Virgulle verilen parametreleri ayirir ve diziye atar
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic; // Basarisiz olan kurali business e hatali diye bildiriyor.
                }
            }

            return null;
        }

    }
}
