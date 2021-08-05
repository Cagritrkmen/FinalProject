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
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
        public  static string ProductCountOfCategoryError="Bir kategoride en fazla 10 çeşit ürün olabilir";
        public static string ProductUpdated="Ürün güncellendi";
        public static string ProductNameAlreadyExists="Ürün adı önceden kullanılmış";
        public static string CategoryLimitExceded="Kategory limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkilendirmeniz yok";
        public static string UserRegistered="Kayıt olundu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Yanlış parola";
        public static string SuccessfulLogin="Başarıyla giriş yapıldı";
        public static string UserAlreadyExists="Kullanıcı zaten mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
