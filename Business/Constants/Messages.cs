using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Ürün adına sahip başka bir ürün var";
        public static string CategoryLimitExceded = "kategori limit aşıldı";
        public static string AuthorizationDenied = "Erişim reddedildi";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string SuccessfulLogin= "Sisteme giriş başarılı";
    }
}
