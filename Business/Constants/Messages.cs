using System;

namespace Business.Constants
{
    public static class Messages
    {
        public static readonly string ProductAdded = "Ürün eklendi";
        public static readonly string ProductNameInvalid = "Ürün ismi geçersiz";
        public static readonly string MaintenanceTime = "Sistem bakımda";
        public static readonly string ProductsListed = "Ürünler listelendi";
        public static readonly string ProductCountOfCategory = "Kategori maksimum ürün adedine ulaşmıştır.";
        public static readonly string ProductNameAlreadyExists = "Bu ürün adı daha önce kullanılmış.";
        public static readonly string CategoryLimitExceded = "Kategori sayısı geçildi.";
        public static readonly string AuthorizationDenied = "Yetkiniz yok.";
        public static readonly string UserRegistered = "Kullanıcı kayıt edildi.";
        public static readonly string UserNotFound = "Kullanıcı bulunamadı.";
        public static readonly string PasswordError = "Şifre hatalı.";
        public static readonly string SuccessfulLogin = "Giriş başarılı.";
        public static readonly string UserAlreadyExists = "Kullanıcı zaten kayıtlı.";
        public static readonly string AccessTokenCreated = "Erişim token oluşturuldu.";
    }
}