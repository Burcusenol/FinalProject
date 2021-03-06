using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductListed="Ürünler listelendi.";
        public static string ProductCountCategoryError="Bir kategoride en fazla 10 ürün olabilir!";
        public static string ProductNameAlreadyExists="Bu isimde başka bir ürün zaten var";
        public static string CategoryLimitExceded="Kategori sınırı aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string UserRegistered="Kullanıcı kayıt oldu.";
        public static string SuccessfulLogin="Başarılı giriş!";
        public static string UserAlreadyExists="Kullanıcı mevcut.";
        public static string PasswordError = "Parola hatası.";
        public static string AccessTokenCreated="Token oluşturuldu.";
    }
}
