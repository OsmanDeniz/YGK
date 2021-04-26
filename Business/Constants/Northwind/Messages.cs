using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants.Northwind
{
    public static class Messages // static = new kullanmak yerine messages.fonkAdi ile kullanilir.
    {
        public static string ProductAdded = "Urun eklendi.";
        public static string ProductNameInvalid = "Urun ismi gecersiz.";

        public static string MaintenanceTime = "Sistem bakim zamani";
        public static string ProductListed = "Listeleme tamamlandi.";
    }
}
