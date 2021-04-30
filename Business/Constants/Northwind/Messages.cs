using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants.Northwind
{
    public static class Messages // static = new kullanmak yerine messages.fonkAdi ile kullanilir.
    {
        public static string ProductAdded = "Urun eklendi.";
        public static string ProductNameInvalid = "Urun ismi gecersiz.";

        public static string MaintenanceTime = "Sistem bakim zamani";
        public static string ProductListed = "Listeleme tamamlandi.";
        public static string ProductCountOfCategoryError = "Bir kategori de en fazla 10 urun olmali";
        public static string ProductNameAlreadyExists = "Urun ilgili kategoride zaten var.";
        public static string CategoryLimitExceded = "Kategori limiti asildi.";
        public static string? AuthorizationDenied = "Erisim Reddedildi, Gecersiz Yetki Seviyesi.";
        public static string UserRegistered= "Kayit Basarili";
        public static string UserNotFound = "Kullanici Bulunamadi.";
        public static string AccessTokenCreated = "Access Token Olusturuldu.";
        public static string UserAlreadyExists="Kullanici zaten mevcut";
        public static string SuccessfulLogin="Giris basariyla yapildi.";
        public static string PasswordError="Hatali sifre";
    }
}
