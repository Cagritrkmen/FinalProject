using Entities.Concrete;
using System;
using System.Collections.Generic;
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
    }
}
