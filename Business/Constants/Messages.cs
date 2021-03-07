using System;
using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün İsmi geçersiz";
        public static string MaintenenceTime = "Bakım zamanı lütfen daha sonra tekrar deneyin";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategory = "Bir kategoride 10 dan fazla ürün olmaz başka kategori deneyin";
        public static string ThereIsOtherProductWithThisName = "Bu isimde başka ürün mevcut";
        public static string ToMuchCategory = "Kategori limiti aşıldı";
        public static string AuthorizationDenied = "İşlemi gerçekleştirmek için yetkiye sahip değilsiniz.";
        public static string UserRegistered = "Kayıt başarılı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Böyle bi kullanıcı var";
        public static string AccessTokenCreated = "AccessTokenCreated";
    }
}
